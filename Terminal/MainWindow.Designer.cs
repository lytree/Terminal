using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal.Gui;
namespace Terminal
{
    public partial class MainWindow : Terminal.Gui.Window
    {
        private Terminal.Gui.Label label1;

        private Terminal.Gui.Button button1;

        private Terminal.Gui.MenuBar menu;
        private void InitializeComponent()
        {
            this.menu = new MenuBar(new MenuBarItem[] {
                new MenuBarItem ("_File", new MenuItem [] {
                    new MenuItem ("_Exit", "", () => {
                        Application.RequestStop ();
                    })
                }),
            });
            this.Width = Dim.Fill(0);
            this.Height = Dim.Fill(0);
            this.X = 0;
            this.Y = 0;
            this.Modal = false;
            this.Text = "";
            this.Border.BorderStyle = Terminal.Gui.BorderStyle.Single;
            this.Border.Effect3D = false;
            this.Border.DrawMarginFrame = true;
            this.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.Add(menu);
        }
    }
}