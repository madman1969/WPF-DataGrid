using System;
using System.ComponentModel;

namespace DataGrid
{
    public enum Gender
    {
        Male,
        Female
    }

    public class Customer : INotifyPropertyChanged
    {
        private string _firstName;
        private string _lastName;
        private Gender _gender;
        private Uri _webSite;
        private bool _newsletter;
        private string _image;

        public string FirstName
        {
            get { return this._firstName; }
            set
            {
              this._firstName = value;
              this.NotifyPropertyChanged("FirstName");
            }
        }

        public string LastName
        {
            get { return this._lastName; }
            set
            {
              this._lastName = value;
              this.NotifyPropertyChanged("LastName");
            }
        }

        public Gender Gender
        {
            get { return this._gender; }
            set
            {
              this._gender = value;
              this.NotifyPropertyChanged("Gender");
            }
        }

        public Uri WebSite
        {
            get { return this._webSite; }
            set
            {
              this._webSite = value;
              this.NotifyPropertyChanged("WebSite");
            }
        }

        public bool ReceiveNewsletter
        {
            get { return this._newsletter; }
            set
            {
              this._newsletter = value;
              this.NotifyPropertyChanged("Newsletter");
            }
        }

        public string Image
        {
            get { return this._image; }
            set
            {
              this._image = value;
              this.NotifyPropertyChanged("Image");
            }
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Private Helpers

        private void NotifyPropertyChanged(string propertyName)
        {
          this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
