﻿#pragma checksum "..\..\..\..\Vues\fenetre_inscription.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F89D22C0014A392FF87403956AEE19B29924E5CC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using JeuBatonnet.Vues;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using WpfAnimatedGif;


namespace JeuBatonnet.Vues {
    
    
    /// <summary>
    /// fenetre_inscription
    /// </summary>
    public partial class fenetre_inscription : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\..\Vues\fenetre_inscription.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBX_Prenom;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Vues\fenetre_inscription.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBX_Nom;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Vues\fenetre_inscription.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBX_Naissance;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Vues\fenetre_inscription.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBX_Telephone;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Vues\fenetre_inscription.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Inscription;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Vues\fenetre_inscription.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBX_Pseudo;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Vues\fenetre_inscription.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBX_Mail;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Vues\fenetre_inscription.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox TBX_Mdp;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/JeuBatonnet;component/vues/fenetre_inscription.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Vues\fenetre_inscription.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TBX_Prenom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TBX_Nom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TBX_Naissance = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TBX_Telephone = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.BTN_Inscription = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\Vues\fenetre_inscription.xaml"
            this.BTN_Inscription.Click += new System.Windows.RoutedEventHandler(this.BTN_Inscription_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TBX_Pseudo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.TBX_Mail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.TBX_Mdp = ((System.Windows.Controls.PasswordBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

