﻿#pragma checksum "..\..\ОкноТайногоСообщения.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AABE0A2BECB44D4FF29C1F064130897AA16DFD324C932D6D2DDB89C64501CBCB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace МногооконноеПриложение {
    
    
    /// <summary>
    /// ОкноТайногоСообщения
    /// </summary>
    public partial class ОкноТайногоСообщения : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\ОкноТайногоСообщения.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox ПарольBox;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\ОкноТайногоСообщения.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label РезультатLabel;
        
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
            System.Uri resourceLocater = new System.Uri("/КалькуляторWPF;component/%d0%9e%d0%ba%d0%bd%d0%be%d0%a2%d0%b0%d0%b9%d0%bd%d0%be%" +
                    "d0%b3%d0%be%d0%a1%d0%be%d0%be%d0%b1%d1%89%d0%b5%d0%bd%d0%b8%d1%8f.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ОкноТайногоСообщения.xaml"
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
            this.ПарольBox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 2:
            this.РезультатLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            
            #line 9 "..\..\ОкноТайногоСообщения.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ПроверитьПароль_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

