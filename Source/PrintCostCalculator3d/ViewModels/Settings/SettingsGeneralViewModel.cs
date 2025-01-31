﻿using MahApps.Metro.Controls.Dialogs;
using PrintCostCalculator3d.Models.Settings;
using PrintCostCalculator3d.Utilities;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows.Data;
using System.Windows.Input;

namespace PrintCostCalculator3d.ViewModels
{
    class SettingsGeneralViewModel : ViewModelBase
    {
        #region Variables
        readonly IDialogCoordinator _dialogCoordinator;
        //readonly bool _isLoading;
        #endregion

        #region Properties
        //public ObservableCollection<ApplicationViewInfo> ApplicationViewCollection { get; set; }
        public ICollectionView Applications { get; set; }

        ApplicationViewInfo _defaultApplicationSelectedItem;
        public ApplicationViewInfo DefaultApplicationSelectedItem
        {
            get => _defaultApplicationSelectedItem;
            set
            {
                if (value == _defaultApplicationSelectedItem)
                    return;

                if (value != null && !IsLoading)
                    SettingsManager.Current.General_DefaultApplicationViewName = value.Name;

                _defaultApplicationSelectedItem = value;
                OnPropertyChanged();
            }
        }

        public ICollectionView ApplicationsVisible { get; set; }

        ApplicationViewInfo _visibleApplicationSelectedItem;
        public ApplicationViewInfo VisibleApplicationSelectedItem
        {
            get => _visibleApplicationSelectedItem;
            set
            {
                if (value == _visibleApplicationSelectedItem)
                    return;

                _visibleApplicationSelectedItem = value;

                ValidateHideVisibleApplications();

                OnPropertyChanged();
            }
        }

        bool _isVisibleToHideApplicationEnabled;
        public bool IsVisibleToHideApplicationEnabled
        {
            get => _isVisibleToHideApplicationEnabled;
            set
            {
                if (value == _isVisibleToHideApplicationEnabled)
                    return;

                _isVisibleToHideApplicationEnabled = value;
                OnPropertyChanged();
            }
        }

        public ICollectionView ApplicationsHidden { get; set; }

        ApplicationViewInfo _hiddenApplicationSelectedItem;
        public ApplicationViewInfo HiddenApplicationSelectedItem
        {
            get => _hiddenApplicationSelectedItem;
            set
            {
                if (value == _hiddenApplicationSelectedItem)
                    return;

                _hiddenApplicationSelectedItem = value;

                ValidateHideVisibleApplications();

                OnPropertyChanged();
            }
        }

        bool _isHideToVisibleApplicationEnabled;
        public bool IsHideToVisibleApplicationEnabled
        {
            get => _isHideToVisibleApplicationEnabled;
            set
            {
                if (value == _isHideToVisibleApplicationEnabled)
                    return;

                _isHideToVisibleApplicationEnabled = value;
                OnPropertyChanged();
            }
        }

        int _backgroundJobInterval;
        public int BackgroundJobInterval
        {
            get => _backgroundJobInterval;
            set
            {
                if (value == _backgroundJobInterval)
                    return;

                if (!IsLoading)
                    SettingsManager.Current.General_BackgroundJobInterval = value;

                _backgroundJobInterval = value;
                OnPropertyChanged();
            }
        }

        int _historyListEntries;
        public int HistoryListEntries
        {
            get => _historyListEntries;
            set
            {
                if (value == _historyListEntries)
                    return;

                if (!IsLoading)
                    SettingsManager.Current.General_HistoryListEntries = value;

                _historyListEntries = value;
                OnPropertyChanged();
            }
        }
        
        bool _overwriteCurrencySymbol;
        public bool OverwriteCurrencySymbol
        {
            get => _overwriteCurrencySymbol;
            set
            {
                if (value == _overwriteCurrencySymbol)
                    return;

                if (!IsLoading)
                {
                    SettingsManager.Current.General_OverwriteCurrencySymbol = value;
                    RestartRequired = (value != _overwriteCurrencySymbol);
                }

                _overwriteCurrencySymbol = value;
                OnPropertyChanged();
            }
        }
        
        bool _overwriteNumberFormats;
        public bool OverwriteNumberFormats
        {
            get => _overwriteNumberFormats;
            set
            {
                if (value == _overwriteNumberFormats)
                    return;

                if (!IsLoading)
                {
                    SettingsManager.Current.General_OverwriteNumberFormats = value;
                    RestartRequired = (value != _overwriteNumberFormats);
                }
                _overwriteNumberFormats = value;
                OnPropertyChanged();
            }
        }
        
        string _CurrencySymbol;
        public string CurrencySymbol
        {
            get => _CurrencySymbol;
            set
            {
                if (value == _CurrencySymbol)
                    return;

                if (!IsLoading)
                    SettingsManager.Current.General_CurrencySymbol = value;

                _CurrencySymbol = value;
                OnPropertyChanged();
            }
        }
        
        string _OverwriteCultureCode;
        public string OverwriteCultureCode
        {
            get => _OverwriteCultureCode;
            set
            {
                if (value == _OverwriteCultureCode)
                    return;

                if (!IsLoading)
                {
                    SettingsManager.Current.General_OverwriteCultureCode = value;
                    RestartRequired = (value != _OverwriteCultureCode);
                }
                _OverwriteCultureCode = value;
                OnPropertyChanged();
            }
        }

        bool _restartRequired;
        public bool RestartRequired
        {
            get => _restartRequired;
            set
            {
                if (value == _restartRequired)
                    return;

                _restartRequired = value;
                OnPropertyChanged();
            }
        }
        

        double _exampleValue = 5;
        public double ExampleValue
        {
            get => _exampleValue;
            set
            {
                if (value == _exampleValue)
                    return;

                _exampleValue = value;
                OnPropertyChanged();
            }
        }

        DateTime _exampleDateTime = DateTime.Now;
        public DateTime ExampleDateTime
        {
            get => _exampleDateTime;
            set
            {
                if (value == _exampleDateTime)
                    return;

                _exampleDateTime = value;
                OnPropertyChanged();
            }
        }
        
        CultureInfo _currentCulture = LocalizationManager.GetInstance().Culture;
        public CultureInfo CurrentCulture
        {
            get => _currentCulture;
            set
            {
                if (value == _currentCulture)
                    return;

                _currentCulture = value;
                OnPropertyChanged();
            }
        }
        
        CultureInfo _selectedCulture = LocalizationManager.GetInstance().Culture;
        public CultureInfo SelectedCulture
        {
            get => _selectedCulture;
            set
            {
                if (value == _selectedCulture)
                    return;

                _selectedCulture = value;
                if (_selectedCulture != null)
                {
                    CurrencySymbol = _selectedCulture.NumberFormat.CurrencySymbol;
                    OverwriteCultureCode = SelectedCulture.Name;
                }
                OnPropertyChanged();
            }
        }

        #region Culture
        ObservableCollection<CultureInfo> _cultures = new ObservableCollection<CultureInfo>();
        public ObservableCollection<CultureInfo> Cultures
        {
            get => _cultures;
            set
            {
                if (_cultures == value) return;
                _cultures = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #endregion

        #region Constructor, LoadSettings
        public SettingsGeneralViewModel()
        {
            Cultures = new ObservableCollection<CultureInfo>(CultureInfo.GetCultures(CultureTypes.AllCultures).Where(c => !c.IsNeutralCulture).ToList());
            IsLoading = true;           
            LoadSettings();
            IsLoading = false;

            SettingsManager.Current.General_ApplicationList.CollectionChanged += General_ApplicationList_CollectionChanged;

            
        }
        public SettingsGeneralViewModel(IDialogCoordinator instance)
        {
            _dialogCoordinator = instance;

            IsLoading = true;
            LoadSettings();
            IsLoading = false;

            SettingsManager.Current.General_ApplicationList.CollectionChanged += General_ApplicationList_CollectionChanged;

            
        }
        void General_ApplicationList_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            ApplicationsVisible.Refresh();
            ApplicationsHidden.Refresh();
        }

        void LoadSettings()
        {
            //ApplicationViewCollection = new ObservableCollection<ApplicationViewInfo>(SettingsManager.Current.General_ApplicationList);
            Applications = new CollectionViewSource { Source = SettingsManager.Current.General_ApplicationList }.View;

            ApplicationsVisible = new CollectionViewSource { Source = SettingsManager.Current.General_ApplicationList }.View;
            ApplicationsVisible.Filter = o =>
            {
                if (!(o is ApplicationViewInfo info))
                    return false;

                return info.IsVisible;
            };

            ApplicationsHidden = new CollectionViewSource { Source = SettingsManager.Current.General_ApplicationList }.View;
            ApplicationsHidden.Filter = o =>
            {
                if (!(o is ApplicationViewInfo info))
                    return false;

                return !info.IsVisible;
            };

            ValidateHideVisibleApplications();

            DefaultApplicationSelectedItem = Applications.Cast<ApplicationViewInfo>().FirstOrDefault(x => x.Name == SettingsManager.Current.General_DefaultApplicationViewName);
            BackgroundJobInterval = SettingsManager.Current.General_BackgroundJobInterval;
            HistoryListEntries = SettingsManager.Current.General_HistoryListEntries;

            OverwriteCurrencySymbol = SettingsManager.Current.General_OverwriteCurrencySymbol;
            CurrencySymbol = SettingsManager.Current.General_CurrencySymbol;

            OverwriteCultureCode = SettingsManager.Current.General_OverwriteCultureCode;
            OverwriteNumberFormats = SettingsManager.Current.General_OverwriteNumberFormats;

            if (!string.IsNullOrEmpty(OverwriteCultureCode))
                SelectedCulture = Cultures.FirstOrDefault(ci => ci.Name == OverwriteCultureCode);
        }
        #endregion

        #region ICommands & Actions
        public ICommand VisibleToHideApplicationCommand
        {
            get { return new RelayCommand(p => VisibleToHideApplicationAction()); }
        }

        void VisibleToHideApplicationAction()
        {
            var index = 0;

            var newDefaultApplication = DefaultApplicationSelectedItem.Name == VisibleApplicationSelectedItem.Name;

            for (var i = 0; i < SettingsManager.Current.General_ApplicationList.Count; i++)
            {
                if (SettingsManager.Current.General_ApplicationList[i].Name != VisibleApplicationSelectedItem.Name)
                    continue;

                index = i;

                break;
            }

            // Remove and add will fire a collection changed event --> detected in MainWindow
            var info = SettingsManager.Current.General_ApplicationList[index];

            info.IsVisible = false;

            SettingsManager.Current.General_ApplicationList.RemoveAt(index);
            SettingsManager.Current.General_ApplicationList.Insert(index, info);

            if (newDefaultApplication)
                DefaultApplicationSelectedItem = ApplicationsVisible.Cast<ApplicationViewInfo>().FirstOrDefault();

            ValidateHideVisibleApplications();
        }

        public ICommand HideToVisibleApplicationCommand
        {
            get { return new RelayCommand(p => HideToVisibleApplicationAction()); }
        }

        void HideToVisibleApplicationAction()
        {
            var index = 0;

            for (var i = 0; i < SettingsManager.Current.General_ApplicationList.Count; i++)
            {
                if (SettingsManager.Current.General_ApplicationList[i].Name == HiddenApplicationSelectedItem.Name)
                {
                    index = i;
                    break;
                }
            }

            // Remove and add will fire a collection changed event --> detected in MainWindow
            var info = SettingsManager.Current.General_ApplicationList[index];

            info.IsVisible = true;

            SettingsManager.Current.General_ApplicationList.RemoveAt(index);
            SettingsManager.Current.General_ApplicationList.Insert(index, info);

            ValidateHideVisibleApplications();
        }
        #endregion

        #region Methods
        void ValidateHideVisibleApplications()
        {
            IsVisibleToHideApplicationEnabled = ApplicationsVisible.Cast<ApplicationViewInfo>().Count() > 1 && VisibleApplicationSelectedItem != null;
            IsHideToVisibleApplicationEnabled = ApplicationsHidden.Cast<ApplicationViewInfo>().Any() && HiddenApplicationSelectedItem != null;
        }
        public void OnViewVisible()
        {

        }

        public void OnViewHide()
        {

        }
        #endregion
    }


}
