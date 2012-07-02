using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MayhemWpf.UserControls;

namespace ShortcutTrigger
{
    /// <summary>
    /// Interaction logic for SetShortcut.xaml
    /// </summary>
    public partial class SetShortcut : WpfConfiguration
    {
        public int selectedIndex = 0;

        public override string Title
        {
            get
            {
                return "Set Shortcut";
            }
        }
        public override void OnLoad()
        {
            base.OnLoad();
        }
        public SetShortcut()
        {
            CanSave = true;
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedIndex = ShortcutType.SelectedIndex;
        }
    }
}
