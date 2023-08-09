using Terminal.Gui;
namespace MenuW
{
    public class MenuWindow
    {
        private const string V = "(c) Format installed csefa iso";

        public void Menu()
        {
            Application.Init();
            var top = Application.Top;
            var win = new Window("CSEFA (Menu)");
            top.Add(win);
            string path_now = Directory.GetCurrentDirectory();
            win.Add(
                new Label(1, 1, "Current path: " + path_now)
            );
            


            
            var listmenu = new ListView(new Rect(1, 3, 40, 10), new string[]{
                    
                   
                
                /*new RadioGroup(1, 1, new*/
                
                    "(a) Auto Start - F2 To enter menu",
                    "(b) Install csefa iso",
                    V,
                    "(d) Reinstall csefa iso",
                    "(e) Uninstall csefa iso",
                    "(f) Reset (return to factory settings) csefa iso",
                    "(g) Start CSEFA",
                    "(z) Exit"
            });
            /*listmenu.Enter += () =>
            {
                if (listmenu.SelectedItem == 7){
                    Application.RequestStop();
                }
            }*/
            listmenu.KeyPress += (e) => {
                if (e.KeyEvent.Key == Key.Enter){
                    if (listmenu.SelectedItem == 7){
                        Application.RequestStop();
                    }
                }
                
            };
            
                

            win.Add(listmenu);
            Application.Run();
            Application.Shutdown();
        }
        

    }
}