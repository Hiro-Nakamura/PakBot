using AmeisenBotX.Core;
using AmeisenBotX.Logging.Enums;
using AmeisenBotX.BehaviorTree.Enums;
using System.Text.Json;
using System.Text.Json.Serialization;
using PakTestWin.Config;

namespace PakTestWin
{
    public partial class Form1 : Form
    {

        public AmeisenBot? Bot = null;
        private PakConfig config;
        private bool shouldRun;

        private Thread ControlLoop;

        public Form1()
        {
            InitializeComponent();

            config = new();

            ControlLoop = new Thread(() =>
            {
                while (shouldRun)
                {
                    Bot.Logic.PakUpdateWowInterface();
                    Thread.Sleep(300);
                }
            });
            
            
            
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            string filePath = String.Empty;
            openWoWExe.InitialDirectory = Directory.GetCurrentDirectory();
            //openWoWExe.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openWoWExe.FilterIndex = 2;
            openWoWExe.RestoreDirectory = true;

            if (openWoWExe.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openWoWExe.FileName;

                //Read the contents of the file into a stream
                //var fileStream = openWoWExe.OpenFile();

                //using (StreamReader reader = new StreamReader(fileStream))
                //{
                //    fileContent = reader.ReadToEnd();
                //}
            }
            lblPathWoW.Text = filePath;
        }
  



        private void btnFindPath_Click(object sender, EventArgs e)
        {

            openConfig.InitialDirectory = Directory.GetCurrentDirectory();
            openConfig.RestoreDirectory = true;

            if (openConfig.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                string filePath = openConfig.FileName;
                labelPath.Text = filePath;

                string jsonString = File.ReadAllText(filePath);
                config =
                JsonSerializer.Deserialize<PakConfig>(jsonString);
                if (config.PathToWoW != String.Empty)
                {
                    lblPathWoW.Text = config.PathToWoW;
                    config?.Actors?.ForEach(actor =>
                    listActors.Items.Add(actor.Character));
                }


            }
        }

        private  void button2_Click(object sender, EventArgs e)
        {
            config.PathToWoW = lblPathWoW.Text;
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(config, options);

            File.WriteAllText(labelPath.Text, jsonString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (config?.Actors == null)
            {
                config.Actors = new();
            }

            // see if there is an entry in our List with the name of the character
            String Char = textCharacter.Text;
            bool foundChar = listActors.Items.Contains(Char);
            if (!foundChar)
            {
                //   Add a new entry in the list with the data
                listActors.Items.Add(Char);
                PakConfigActor newActor = new();
                newActor.Username = textUsername.Text;
                newActor.Password = textPassword.Text;
                newActor.Realm = textRealm.Text;
                newActor.Character = textCharacter.Text;

                config?.Actors?.Add(newActor);

            } else
            {
                //   update an entry in the list with the data
                PakConfigActor? obj = config?.Actors?.FirstOrDefault(x => x.Character == Char);
                if (obj != null)
                {
                    obj.Username = textUsername.Text;
                    obj.Password = textPassword.Text;
                    obj.Realm = textRealm.Text;
                    obj.Character = textCharacter.Text;
                }
            }
           
        }

        private void listActors_Clear()
        {
            textUsername.Text = "";
            textPassword.Text = "";
            textRealm.Text = "";
            textCharacter.Text = "";
        }

        private void listActors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listActors.SelectedItem == null) return;

            String? charName = listActors.SelectedItem.ToString();
            if (charName != null)
            {
                PakConfigActor? actor = config?.Actors?.FirstOrDefault(x => x.Character == charName);
                if (actor != null)
                {
                    textUsername.Text = actor.Username;
                    textPassword.Text = actor.Password;
                    textRealm.Text = actor.Realm;
                    textCharacter.Text = actor.Character;
                }
            }
        }

        private void btnActorRemove_Click(object sender, EventArgs e)
        {
            String? charName = listActors.SelectedItem.ToString();
            if (charName != null)
            {
                listActors.Items.Remove(charName);
                listActors_Clear();

                PakConfigActor? actor = config?.Actors?.FirstOrDefault(x => x.Character == charName);
                if (actor != null)
                {
                    config?.Actors?.Remove(actor);
                }
            }
        }


        private void btnConnect_Click(object sender, EventArgs e)
        {
            shouldRun = !shouldRun;

            if (shouldRun && Bot == null)
            {
                startup();
            }
            if (shouldRun && !ControlLoop.IsAlive)
            {
                ControlLoop.Start();
            }
        }

        private void startup()
        {

            if (startup_InitAmeisenBot())
            {
                startup_Login();
            }
        }
        private bool startup_InitAmeisenBot()
        {
            AmeisenBotConfig conf = new();
            conf.Path = labelPath.Text; // "C:\\Users\\Johnny\\Desktop\\Pak";
            conf.PathToWowExe = lblPathWoW.Text;
            conf.Username = textUsername.Text;
            conf.Password = textPassword.Text;
            conf.Realm = textRealm.Text;
            conf.CharacterSlot = 0;

            LogLevel logLevel = AmeisenBotX.Logging.Enums.LogLevel.Verbose;

            Bot = new(conf, "DEFAULT", logLevel);

            return true;
        }

        private bool startup_Login()
        {
            // AmeisenBotLogic.StartWow()
            BtStatus statusWow = Bot.Logic.PakStartWow();
            if (statusWow == BtStatus.Success)
            {
                BtStatus statusWowSetup = Bot.Logic.PakSetupWowInterface();
                if (BtStatus.Success == statusWowSetup)
                {
                    //while(Bot.Wow.isReady)
                    BtStatus statusLogin = Bot.Logic.PakLogin();
                    if (statusLogin == BtStatus.Success)
                    {
                        while(Bot.Logic.PakNeedToLogin())
                        {
                            Bot.Logic.PakLogin();
                            Thread.Sleep(1000);
                        }
                        return true;
                    }
                }

            }
            

            return false;
        }
    }
}

