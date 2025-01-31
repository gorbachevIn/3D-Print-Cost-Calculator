﻿using AndreasReitberger.Models;
using ICSharpCode.AvalonEdit.Document;
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Utils;
using PrintCostCalculator3d.Models.Settings;
using PrintCostCalculator3d.Models.SyntaxHighlighting;
using PrintCostCalculator3d.Resources.Localization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PrintCostCalculator3d.ViewModels
{
    class CodeEditorViewModel : PaneViewModel
    {

        #region Properties
        bool _isEdit;
        public bool IsEdit
        {
            get => _isEdit;
            set
            {
                if (value == _isEdit)
                    return;

                _isEdit = value;
                OnPropertyChanged();
            }
        }

        int _tabId = 0;
        public int TabId
        {
            get => _tabId;
            set
            {
                if (value == _tabId)
                    return;

                _tabId = value;
                OnPropertyChanged();
            }
        }

        Guid _id = Guid.NewGuid();
        public Guid Id
        {
            get => _id;
            set
            {
                if (_id != value)
                {
                    _id = value;
                    OnPropertyChanged();
                }
            }
        }

        Gcode _gcode;
        public Gcode Gcode
        {
            get => _gcode;
            set
            {
                if (_gcode != value)
                {
                    _gcode = value;
                    OnPropertyChanged();
                }
            }
        }

        List<GcodeCommandLine> _selectedLine = new List<GcodeCommandLine>();
        public List<GcodeCommandLine> SelectedLine
        {
            get => _selectedLine;
            set
            {
                if (_selectedLine == value)
                    return;
                _selectedLine = value;
                OnPropertyChanged();
            }
        }

        #region SyntaxHighlighter
        string _filePath = string.Empty;
        public string FilePath
        {
            get => _filePath;
            set
            {
                if (_filePath == value)
                    return;
                _filePath = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(FileName));
                OnPropertyChanged(nameof(Title));
                readFile(FilePath);
            }
        }

        string _fileName = string.Empty;
        public string FileName
        {
            get
            {
                if (string.IsNullOrEmpty(FilePath))
                    return string.Format("{0}{1}", Strings.New, IsDirty ? "*" : string.Empty);
                return string.Format(Path.GetFileName(FilePath), IsDirty ? "*" : string.Empty);
            }
        }

        TextDocument _document = new TextDocument();
        public TextDocument Document
        {
            get => _document;
            set
            {
                if (_document == value)
                    return;
                _document = value;
                OnPropertyChanged();
                IsDirty = true;
            }
        }

        IHighlightingDefinition _highlightdef = null;
        public IHighlightingDefinition HighlightDef
        {
            get => _highlightdef;
            set
            {
                if (_highlightdef == value)
                    return;
                _highlightdef = value;
                OnPropertyChanged();
                IsDirty = true;
            }
        }

        public new string Title
        {
            get
            {
                return Path.GetFileName(this.FilePath) + (IsDirty ? "*" : string.Empty);
            }

            set
            {
                base.Title = value;
            }
        }

        bool _isDirty = false;
        public bool IsDirty
        {
            get { return _isDirty; }
            set
            {
                if (_isDirty != value)
                {
                    _isDirty = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Title));
                    OnPropertyChanged(nameof(FileName));
                }
            }
        }

        bool _isReadOnly = false;
        public bool IsReadOnly
        {
            get => _isReadOnly;

            protected set
            {
                if (_isReadOnly == value)
                    return;
                _isReadOnly = value;
                OnPropertyChanged();
            }
        }

        string _IsReadOnlyReason = string.Empty;
        public string IsReadOnlyReason
        {
            get => _IsReadOnlyReason;

            protected set
            {
                if (_IsReadOnlyReason == value)
                    return;
                _IsReadOnlyReason = value;
                OnPropertyChanged();
            }
        }

        bool _WordWrap = false;
        public bool WordWrap
        {
            get => _WordWrap;

            set
            {
                if (_WordWrap == value)
                    return;
                _WordWrap = value;
                OnPropertyChanged();
            }
        }

        bool _ShowLineNumbers = false;
        public bool ShowLineNumbers
        {
            get => _ShowLineNumbers;

            set
            {
                if (_ShowLineNumbers == value)
                    return;
                _ShowLineNumbers = value;
                OnPropertyChanged();
            }
        }

        ICSharpCode.AvalonEdit.TextEditorOptions _TextOptions = new ICSharpCode.AvalonEdit.TextEditorOptions()
        {
            ConvertTabsToSpaces = false,
            IndentationSize = 2
        };

        public ICSharpCode.AvalonEdit.TextEditorOptions TextOptions
        {
            get => _TextOptions;

            set
            {
                if (_TextOptions == value)
                    return;
                _TextOptions = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #endregion

        #region Settings

        #endregion

        #region Constructor
        public CodeEditorViewModel(int tabId, Gcode file = null)
        {
            TabId = tabId;
            IsLicenseValid = false;

            Gcode = file;
            if(Gcode != null)
            {
                readFile(Gcode.FilePath);
            }
        }
        #endregion

        #region Methods

        void readFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                var ext = Path.GetExtension(filePath);
                this.Document = new TextDocument();
                this.HighlightDef = HighlightingManager.Instance.GetDefinitionByExtension(ext);
                this.IsDirty = false;
                this.IsReadOnly = false;
                this.ShowLineNumbers = false;
                this.WordWrap = false;

                // Check file attributes and set to read-only if file attributes indicate that
                if ((File.GetAttributes(filePath) & FileAttributes.ReadOnly) != 0)
                {
                    this.IsReadOnly = true;
                    this.IsReadOnlyReason = "This file cannot be edit because another process is currently writting to it.\n" +
                                            "Change the file access permissions or save the file in a different location if you want to edit it.";
                }

                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    using (StreamReader reader = FileReader.OpenStream(fs, Encoding.UTF8))
                    {
                        this._document = new TextDocument(reader.ReadToEnd());
                    }
                }

                ContentId = _filePath;
            }
        }
        #endregion  

        #region Events
        public void OnClose()
        {
            
        }
        #endregion

        #region iCommands & Actions

        #endregion
    }
}
