using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using MayhemCore;
using System.Windows.Input;
using System.Windows.Forms;
using MayhemWpf.ModuleTypes;
using MayhemWpf.UserControls;

namespace ShortcutTrigger
{
    [DataContract]

    [MayhemModule("Keyboard Shortcut", "Triggers a keyboard shortcut in the current context.")] 


    public class Shortcut: ReactionBase, IWpfConfigurable 
    {

        [DataMember]

        private string[] option = { "(^c)", "(^v)", "(^p)", "(%{TAB})", "(^+){ESC}", "(%{F4})" };

        private static int selected = 0;

        public override void Perform()
        {
            try
            {
                SendKeys.SendWait(option[selected]);
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e.Message);
            }
        }



        public WpfConfiguration ConfigurationControl
        {
            get { return new SetShortcut(); }
        }

        public void OnSaved(WpfConfiguration configurationControl)
        {
            selected = ((SetShortcut)configurationControl).selectedIndex;
        }
        
        public string GetConfigString()
        {
            return "This";
        }
    }
}
