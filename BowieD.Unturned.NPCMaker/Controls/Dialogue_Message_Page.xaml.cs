﻿using BowieD.Unturned.NPCMaker.Common;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace BowieD.Unturned.NPCMaker.Controls
{
    /// <summary>
    /// Логика взаимодействия для Dialogue_Message_Page.xaml
    /// </summary>
    public partial class Dialogue_Message_Page : UserControl, IHasOrderButtons
    {
        public Dialogue_Message_Page(string text)
        {
            InitializeComponent();
            textField.Text = text;

            ContextMenu cmenu = new ContextMenu();

            cmenu.Items.Add(ContextHelper.CreatePastePauseButton());
            cmenu.Items.Add(ContextHelper.CreatePasteNewLineButton());
            cmenu.Items.Add(ContextHelper.CreatePastePlayerNameButton());
            cmenu.Items.Add(ContextHelper.CreatePasteNPCNameButton());
            cmenu.Items.Add(ContextHelper.CreatePasteItalicButton());
            cmenu.Items.Add(ContextHelper.CreatePasteBoldButton());
            cmenu.Items.Add(ContextHelper.CreatePasteColorMenu());

            textField.ContextMenu = cmenu;
        }

        public string Page { get; private set; }

        public UIElement UpButton => moveUpButton;

        public UIElement DownButton => moveDownButton;

        public Transform Transform => tranform;

        public double Hidden_Opacity = 0.5;
        public double Visible_Opacity = 1;
        private void TextField_TextChanged(object sender, TextChangedEventArgs e)
        {
            Page = textField.Text;
        }
    }
}
