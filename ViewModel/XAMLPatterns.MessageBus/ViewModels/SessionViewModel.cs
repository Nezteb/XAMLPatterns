﻿using GalaSoft.MvvmLight;
using XAMLPatterns.MessageBus.Models;

namespace XAMLPatterns.MessageBus.ViewModels
{
    public class SessionViewModel : ViewModelBase
    {
        private ConferenceService _conferenceService;
        private int _id;
        private string _speaker;
        private string _title;

        public SessionViewModel()
        {
            _conferenceService = new ConferenceService();
        }

        public string Speaker
        {
            get { return _speaker; }
            set
            {
                if (value == _speaker)
                    return;

                RaisePropertyChanging(() => this.Speaker);
                _speaker = value;
                RaisePropertyChanged(() => this.Speaker);
            }
        }

        public string Title
        {
            get { return _title; }
            set
            {
                if (value == _title)
                    return;

                RaisePropertyChanging(() => this.Title);
                _title = value;
                RaisePropertyChanged(() => this.Title);
            }
        }
    }
}
