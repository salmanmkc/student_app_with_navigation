﻿#pragma checksum "C:\Users\13sch\source\repos\App5\App5\Views\NotesPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B7120A00754CD8973535E7189BF1C7C3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App5.Views
{
    partial class NotesPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_Control_IsEnabled(global::Windows.UI.Xaml.Controls.Control obj, global::System.Boolean value)
            {
                obj.IsEnabled = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class NotesPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            INotesPage_Bindings
        {
            private global::App5.Views.NotesPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.AppBarButton obj27;
            private global::Windows.UI.Xaml.Controls.AppBarButton obj28;
            private global::Windows.UI.Xaml.Controls.AppBarButton obj29;
            private global::Windows.UI.Xaml.Controls.AppBarButton obj30;
            private global::Windows.UI.Xaml.Controls.AppBarButton obj31;
            private global::Windows.UI.Xaml.Controls.AppBarButton obj33;
            private global::Windows.UI.Xaml.Controls.AppBarButton obj34;
            private global::Windows.UI.Xaml.Controls.AppBarButton obj35;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj27IsEnabledDisabled = false;
            private static bool isobj28IsEnabledDisabled = false;
            private static bool isobj29IsEnabledDisabled = false;
            private static bool isobj30IsEnabledDisabled = false;
            private static bool isobj31IsEnabledDisabled = false;
            private static bool isobj33IsEnabledDisabled = false;
            private static bool isobj34IsEnabledDisabled = false;
            private static bool isobj35IsEnabledDisabled = false;

            private NotesPage_obj1_BindingsTracking bindingsTracking;

            public NotesPage_obj1_Bindings()
            {
                this.bindingsTracking = new NotesPage_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 128 && columnNumber == 84)
                {
                    isobj27IsEnabledDisabled = true;
                }
                else if (lineNumber == 129 && columnNumber == 87)
                {
                    isobj28IsEnabledDisabled = true;
                }
                else if (lineNumber == 130 && columnNumber == 90)
                {
                    isobj29IsEnabledDisabled = true;
                }
                else if (lineNumber == 132 && columnNumber == 87)
                {
                    isobj30IsEnabledDisabled = true;
                }
                else if (lineNumber == 133 && columnNumber == 87)
                {
                    isobj31IsEnabledDisabled = true;
                }
                else if (lineNumber == 136 && columnNumber == 101)
                {
                    isobj33IsEnabledDisabled = true;
                }
                else if (lineNumber == 137 && columnNumber == 109)
                {
                    isobj34IsEnabledDisabled = true;
                }
                else if (lineNumber == 139 && columnNumber == 97)
                {
                    isobj35IsEnabledDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 27: // Views\NotesPage.xaml line 128
                        this.obj27 = (global::Windows.UI.Xaml.Controls.AppBarButton)target;
                        break;
                    case 28: // Views\NotesPage.xaml line 129
                        this.obj28 = (global::Windows.UI.Xaml.Controls.AppBarButton)target;
                        break;
                    case 29: // Views\NotesPage.xaml line 130
                        this.obj29 = (global::Windows.UI.Xaml.Controls.AppBarButton)target;
                        break;
                    case 30: // Views\NotesPage.xaml line 132
                        this.obj30 = (global::Windows.UI.Xaml.Controls.AppBarButton)target;
                        break;
                    case 31: // Views\NotesPage.xaml line 133
                        this.obj31 = (global::Windows.UI.Xaml.Controls.AppBarButton)target;
                        break;
                    case 33: // Views\NotesPage.xaml line 136
                        this.obj33 = (global::Windows.UI.Xaml.Controls.AppBarButton)target;
                        break;
                    case 34: // Views\NotesPage.xaml line 137
                        this.obj34 = (global::Windows.UI.Xaml.Controls.AppBarButton)target;
                        break;
                    case 35: // Views\NotesPage.xaml line 139
                        this.obj35 = (global::Windows.UI.Xaml.Controls.AppBarButton)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                throw new global::System.NotImplementedException();
            }

            public void Recycle()
            {
                throw new global::System.NotImplementedException();
            }

            // INotesPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::App5.Views.NotesPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::App5.Views.NotesPage obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_CutButtonIsEnabled(obj.CutButtonIsEnabled, phase);
                        this.Update_CopyButtonIsEnabled(obj.CopyButtonIsEnabled, phase);
                        this.Update_PasteButtonIsEnabled(obj.PasteButtonIsEnabled, phase);
                        this.Update_UndoButtonIsEnabled(obj.UndoButtonIsEnabled, phase);
                        this.Update_RedoButtonIsEnabled(obj.RedoButtonIsEnabled, phase);
                        this.Update_SaveInkFileButtonIsEnabled(obj.SaveInkFileButtonIsEnabled, phase);
                        this.Update_ExportAsImageButtonIsEnabled(obj.ExportAsImageButtonIsEnabled, phase);
                        this.Update_ClearAllButtonIsEnabled(obj.ClearAllButtonIsEnabled, phase);
                    }
                }
            }
            private void Update_CutButtonIsEnabled(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\NotesPage.xaml line 128
                    if (!isobj27IsEnabledDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj27, obj);
                    }
                }
            }
            private void Update_CopyButtonIsEnabled(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\NotesPage.xaml line 129
                    if (!isobj28IsEnabledDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj28, obj);
                    }
                }
            }
            private void Update_PasteButtonIsEnabled(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\NotesPage.xaml line 130
                    if (!isobj29IsEnabledDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj29, obj);
                    }
                }
            }
            private void Update_UndoButtonIsEnabled(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\NotesPage.xaml line 132
                    if (!isobj30IsEnabledDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj30, obj);
                    }
                }
            }
            private void Update_RedoButtonIsEnabled(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\NotesPage.xaml line 133
                    if (!isobj31IsEnabledDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj31, obj);
                    }
                }
            }
            private void Update_SaveInkFileButtonIsEnabled(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\NotesPage.xaml line 136
                    if (!isobj33IsEnabledDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj33, obj);
                    }
                }
            }
            private void Update_ExportAsImageButtonIsEnabled(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\NotesPage.xaml line 137
                    if (!isobj34IsEnabledDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj34, obj);
                    }
                }
            }
            private void Update_ClearAllButtonIsEnabled(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\NotesPage.xaml line 139
                    if (!isobj35IsEnabledDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj35, obj);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class NotesPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<NotesPage_obj1_Bindings> weakRefToBindingObj; 

                public NotesPage_obj1_BindingsTracking(NotesPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<NotesPage_obj1_Bindings>(obj);
                }

                public NotesPage_obj1_Bindings TryGetBindingObject()
                {
                    NotesPage_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_(null);
                }

                public void PropertyChanged_(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    NotesPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::App5.Views.NotesPage obj = sender as global::App5.Views.NotesPage;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_CutButtonIsEnabled(obj.CutButtonIsEnabled, DATA_CHANGED);
                                bindings.Update_CopyButtonIsEnabled(obj.CopyButtonIsEnabled, DATA_CHANGED);
                                bindings.Update_PasteButtonIsEnabled(obj.PasteButtonIsEnabled, DATA_CHANGED);
                                bindings.Update_UndoButtonIsEnabled(obj.UndoButtonIsEnabled, DATA_CHANGED);
                                bindings.Update_RedoButtonIsEnabled(obj.RedoButtonIsEnabled, DATA_CHANGED);
                                bindings.Update_SaveInkFileButtonIsEnabled(obj.SaveInkFileButtonIsEnabled, DATA_CHANGED);
                                bindings.Update_ExportAsImageButtonIsEnabled(obj.ExportAsImageButtonIsEnabled, DATA_CHANGED);
                                bindings.Update_ClearAllButtonIsEnabled(obj.ClearAllButtonIsEnabled, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "CutButtonIsEnabled":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_CutButtonIsEnabled(obj.CutButtonIsEnabled, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "CopyButtonIsEnabled":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_CopyButtonIsEnabled(obj.CopyButtonIsEnabled, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "PasteButtonIsEnabled":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_PasteButtonIsEnabled(obj.PasteButtonIsEnabled, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "UndoButtonIsEnabled":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_UndoButtonIsEnabled(obj.UndoButtonIsEnabled, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "RedoButtonIsEnabled":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_RedoButtonIsEnabled(obj.RedoButtonIsEnabled, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "SaveInkFileButtonIsEnabled":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_SaveInkFileButtonIsEnabled(obj.SaveInkFileButtonIsEnabled, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "ExportAsImageButtonIsEnabled":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ExportAsImageButtonIsEnabled(obj.ExportAsImageButtonIsEnabled, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "ClearAllButtonIsEnabled":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ClearAllButtonIsEnabled(obj.ClearAllButtonIsEnabled, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void UpdateChildListeners_(global::App5.Views.NotesPage obj)
                {
                    NotesPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        if (bindings.dataRoot != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)bindings.dataRoot).PropertyChanged -= PropertyChanged_;
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\NotesPage.xaml line 52
                {
                    global::Windows.UI.Xaml.Controls.InkToolbar element2 = (global::Windows.UI.Xaml.Controls.InkToolbar)(target);
                    ((global::Windows.UI.Xaml.Controls.InkToolbar)element2).Loaded += this.OnInkToolbarLoaded;
                }
                break;
            case 4: // Views\NotesPage.xaml line 13
                {
                    global::Windows.UI.Xaml.Controls.InkToolbar element4 = (global::Windows.UI.Xaml.Controls.InkToolbar)(target);
                    ((global::Windows.UI.Xaml.Controls.InkToolbar)element4).Loaded += this.OnInkToolbarLoaded;
                }
                break;
            case 5: // Views\NotesPage.xaml line 28
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element5 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element5).Click += this.ZoomIn_Click;
                }
                break;
            case 6: // Views\NotesPage.xaml line 29
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element6 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element6).Click += this.ZoomOut_Click;
                }
                break;
            case 7: // Views\NotesPage.xaml line 30
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element7 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element7).Click += this.SaveInkFile_Click;
                }
                break;
            case 8: // Views\NotesPage.xaml line 31
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element8 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element8).Click += this.LoadInkFile_Click;
                }
                break;
            case 9: // Views\NotesPage.xaml line 35
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element9 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element9).Click += this.Cut_Click;
                }
                break;
            case 10: // Views\NotesPage.xaml line 36
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element10 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element10).Click += this.Copy_Click;
                }
                break;
            case 11: // Views\NotesPage.xaml line 37
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element11 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element11).Click += this.Paste_Click;
                }
                break;
            case 12: // Views\NotesPage.xaml line 39
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element12 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element12).Click += this.Undo_Click;
                }
                break;
            case 13: // Views\NotesPage.xaml line 40
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element13 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element13).Click += this.Redo_Click;
                }
                break;
            case 14: // Views\NotesPage.xaml line 42
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element14 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element14).Click += this.LoadInkFile_Click;
                }
                break;
            case 15: // Views\NotesPage.xaml line 43
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element15 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element15).Click += this.SaveInkFile_Click;
                }
                break;
            case 16: // Views\NotesPage.xaml line 44
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element16 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element16).Click += this.ExportAsImage_Click;
                }
                break;
            case 17: // Views\NotesPage.xaml line 46
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element17 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element17).Click += this.ClearAll_Click;
                }
                break;
            case 18: // Views\NotesPage.xaml line 66
                {
                    this.ContentArea = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 19: // Views\NotesPage.xaml line 68
                {
                    this.visualStateGroup = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                    ((global::Windows.UI.Xaml.VisualStateGroup)this.visualStateGroup).CurrentStateChanged += this.VisualStateGroup_CurrentStateChanged;
                }
                break;
            case 20: // Views\NotesPage.xaml line 69
                {
                    this.SmallVisualState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 21: // Views\NotesPage.xaml line 74
                {
                    this.BigVisualState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 22: // Views\NotesPage.xaml line 85
                {
                    this.HeaderPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 23: // Views\NotesPage.xaml line 100
                {
                    this.canvasScroll = (global::Windows.UI.Xaml.Controls.ScrollViewer)(target);
                }
                break;
            case 24: // Views\NotesPage.xaml line 119
                {
                    this.bottomCommandBar = (global::Windows.UI.Xaml.Controls.CommandBar)(target);
                }
                break;
            case 25: // Views\NotesPage.xaml line 124
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element25 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element25).Click += this.ZoomIn_Click;
                }
                break;
            case 26: // Views\NotesPage.xaml line 125
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element26 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element26).Click += this.ZoomOut_Click;
                }
                break;
            case 27: // Views\NotesPage.xaml line 128
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element27 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element27).Click += this.Cut_Click;
                }
                break;
            case 28: // Views\NotesPage.xaml line 129
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element28 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element28).Click += this.Copy_Click;
                }
                break;
            case 29: // Views\NotesPage.xaml line 130
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element29 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element29).Click += this.Paste_Click;
                }
                break;
            case 30: // Views\NotesPage.xaml line 132
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element30 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element30).Click += this.Undo_Click;
                }
                break;
            case 31: // Views\NotesPage.xaml line 133
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element31 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element31).Click += this.Redo_Click;
                }
                break;
            case 32: // Views\NotesPage.xaml line 135
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element32 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element32).Click += this.LoadInkFile_Click;
                }
                break;
            case 33: // Views\NotesPage.xaml line 136
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element33 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element33).Click += this.SaveInkFile_Click;
                }
                break;
            case 34: // Views\NotesPage.xaml line 137
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element34 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element34).Click += this.ExportAsImage_Click;
                }
                break;
            case 35: // Views\NotesPage.xaml line 139
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element35 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element35).Click += this.ClearAll_Click;
                }
                break;
            case 36: // Views\NotesPage.xaml line 110
                {
                    this.inkCanvas = (global::Windows.UI.Xaml.Controls.InkCanvas)(target);
                }
                break;
            case 37: // Views\NotesPage.xaml line 113
                {
                    this.selectionCanvas = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 38: // Views\NotesPage.xaml line 86
                {
                    this.Header = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 39: // Views\NotesPage.xaml line 90
                {
                    this.btnSave = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 40: // Views\NotesPage.xaml line 93
                {
                    this.btnLoad = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 41: // Views\NotesPage.xaml line 96
                {
                    this.btnClear = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Views\NotesPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    NotesPage_obj1_Bindings bindings = new NotesPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

