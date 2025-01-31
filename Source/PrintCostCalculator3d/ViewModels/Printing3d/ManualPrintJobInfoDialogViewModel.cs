﻿using AndreasReitberger.Enums;
using MahApps.Metro.Controls.Dialogs;
using PrintCostCalculator3d.Models.Settings;
using PrintCostCalculator3d.Resources.Localization;
using PrintCostCalculator3d.Utilities;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PrintCostCalculator3d.ViewModels._3dPrinting
{
    public class ManualPrintJobInfoDialogViewModel : ViewModelBase
    {
        #region Variables
        readonly IDialogCoordinator _dialogCoordinator;
        #endregion

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

        Guid _id = Guid.NewGuid();
        public Guid Id
        {
            get => _id;
            set
            {
                if (_id == value) return;
                _id = value;
                OnPropertyChanged();
            }
        }

        string _name = string.Empty;
        public string Name
        {
            get => _name;
            set
            {
                if (_name == value) return;
                _name = value;
                OnPropertyChanged();
            }
        }

        double _volume = 0;
        public double Volume
        {
            get => _volume;
            set
            {
                if (_volume == value) return;
                _volume = value;
                OnPropertyChanged();
            }
        }

        double _weight = 0;
        public double Weight
        {
            get => _weight;
            set
            {
                if (_weight == value) return;
                _weight = value;
                OnPropertyChanged();
            }
        }

        Unit _unit = Unit.g;
        public Unit Unit
        {
            get => _unit;
            set
            {
                if (_unit == value) return;
                _unit = value;
                OnPropertyChanged();
            }
        }

        int _quantity = 1;
        public int Quantity
        {
            get => _quantity;
            set
            {
                if (_quantity == value) return;
                _quantity = value;
                OnPropertyChanged();
            }
        }

        double _duration = 0;
        public double Duration
        {
            get => _duration;
            set
            {
                if (_duration == value) return;
                _duration = value;
                OnPropertyChanged();

            }
        }

        bool _useVolumeForCalculation = true;
        public bool UseVolumeForCalculation
        {
            get => _useVolumeForCalculation;
            set
            {
                if (value == _useVolumeForCalculation)
                    return;

                if (!IsLoading)
                    SettingsManager.Current.Calculation_UseVolumeForCalculation = value;

                _useVolumeForCalculation = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region EnumCollections

        #region Units
        ObservableCollection<Unit> _units = new(
            Enum.GetValues(typeof(Unit)).Cast<Unit>().ToList()
            );
        public ObservableCollection<Unit> Units
        {
            get => _units;
            set
            {
                if (_units == value)
                {
                    return;
                }

                _units = value;
                OnPropertyChanged();

            }
        }

        #endregion

        #endregion

        #region Constructor, LoadSettings
        public ManualPrintJobInfoDialogViewModel(Action<ManualPrintJobInfoDialogViewModel> saveCommand, Action<ManualPrintJobInfoDialogViewModel> cancelHandler, IDialogCoordinator dialogCoordinator)
        {
            SaveCommand = new RelayCommand(p => saveCommand(this));
            CancelCommand = new RelayCommand(p => cancelHandler(this));

            _dialogCoordinator = dialogCoordinator;

            IsLicenseValid = false;

            IsLoading = true;
            LoadSettings();
            IsLoading = false;
        }

        void LoadSettings()
        {
            UseVolumeForCalculation = SettingsManager.Current.Calculation_UseVolumeForCalculation;
        }
        #endregion

        #region ICommands & Actions
        public ICommand SaveCommand { get; }

        public ICommand CancelCommand { get; }

        public ICommand CalculateVolumeCommand
        {
            get => new RelayCommand(async (p) => await CalculateVolumeAction());
        }
        async Task CalculateVolumeAction()
        {
            try
            {
                var _dialog = new CustomDialog() { Title = Strings.CalculateVolume };
                var newViewModel = new CalculateVolumeDialogViewModel(async instance =>
                {
                    await _dialogCoordinator.HideMetroDialogAsync(this, _dialog);
                    Volume = instance.Volume;

                    //logger.Info(string.Format(Strings.EventAddedItemFormated, selectedPrinter, Printers[Printers.Count - 1].Name));
                }, instance =>
                {
                    _dialogCoordinator.HideMetroDialogAsync(this, _dialog);
                }
                );

                _dialog.Content = new Views._3dPrinting.CalculateVolumeDialog()
                {
                    DataContext = newViewModel
                };
                await _dialogCoordinator.ShowMetroDialogAsync(this, _dialog);
            }
            catch (Exception exc)
            {
                logger.Error(string.Format(Strings.EventExceptionOccurredFormated, exc.TargetSite, exc.Message));
                await _dialogCoordinator.ShowMessageAsync(this,
                    Strings.DialogExceptionHeadline,
                    string.Format(Strings.DialogExceptionFormatedContent, exc.Message)
                    );
            }
        }

        public ICommand CalculateWeightCommand
        {
            get => new RelayCommand(async (p) => await CalculateWeightAction());
        }
        async Task CalculateWeightAction()
        {
            try
            {
                var _dialog = new CustomDialog() { Title = Strings.CalculateWeight };
                var newViewModel = new CalculateWeightDialogViewModel(async instance =>
                {
                    await _dialogCoordinator.HideMetroDialogAsync(this, _dialog);
                    Weight = instance.Weight;
                    Unit = instance.Unit;
 
                    //logger.Info(string.Format(Strings.EventAddedItemFormated, selectedPrinter, Printers[Printers.Count - 1].Name));
                }, instance =>
                {
                    _dialogCoordinator.HideMetroDialogAsync(this, _dialog);
                }
                );

                _dialog.Content = new Views._3dPrinting.CalculateWeightDialog()
                {
                    DataContext = newViewModel
                };
                await _dialogCoordinator.ShowMetroDialogAsync(this, _dialog);
            }
            catch (Exception exc)
            {
                logger.Error(string.Format(Strings.EventExceptionOccurredFormated, exc.TargetSite, exc.Message));
                await _dialogCoordinator.ShowMessageAsync(this,
                    Strings.DialogExceptionHeadline,
                    string.Format(Strings.DialogExceptionFormatedContent, exc.Message)
                    );
            }
        }
        #endregion
    }
}
