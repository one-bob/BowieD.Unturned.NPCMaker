﻿#pragma checksum "..\..\..\Controls\PlayerAnswer.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1F4D96C2437BDF219AEC9896657B03D39DCBF56E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using BowieD.Unturned.NPCMaker.Controls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace BowieD.Unturned.NPCMaker.Controls {
    
    
    /// <summary>
    /// PlayerAnswer
    /// </summary>
    public partial class PlayerAnswer : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\Controls\PlayerAnswer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox visibleText;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\Controls\PlayerAnswer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button editConditionButton;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Controls\PlayerAnswer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox dialogueId;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Controls\PlayerAnswer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox vendorId;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Controls\PlayerAnswer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox questId;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Controls\PlayerAnswer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button removeReplyButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BowieD.Unturned.NPCMaker;component/controls/playeranswer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Controls\PlayerAnswer.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.visibleText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.editConditionButton = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\..\Controls\PlayerAnswer.xaml"
            this.editConditionButton.Click += new System.Windows.RoutedEventHandler(this.EditConditionButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dialogueId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.vendorId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.questId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.removeReplyButton = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

