﻿#pragma checksum "..\..\ModifCetteSaison.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42706DE47CCDB159342C76C9CD09F73CA53C5531"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using ProjetGraphique;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace ProjetGraphique {
    
    
    /// <summary>
    /// ModifCetteSaison
    /// </summary>
    public partial class ModifCetteSaison : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\ModifCetteSaison.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelNomSaisonAModif;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\ModifCetteSaison.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxNomSaisonAModif;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\ModifCetteSaison.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelDescriptionSaisonAModif;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\ModifCetteSaison.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxDescriptionSaisonAModif;
        
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
            System.Uri resourceLocater = new System.Uri("/ProjetGraphique;component/modifcettesaison.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ModifCetteSaison.xaml"
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
            this.LabelNomSaisonAModif = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.TextBoxNomSaisonAModif = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.LabelDescriptionSaisonAModif = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.TextBoxDescriptionSaisonAModif = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            
            #line 35 "..\..\ModifCetteSaison.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EnregistrerModifSaison);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 36 "..\..\ModifCetteSaison.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AnnulerModifSaison);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

