using KanjiStudy.DataModels;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace KanjiStudy.ViewModels
{
    public class KanjiCompoundViewModel : INotifyPropertyChanged
    {
        readonly IList<KanjiCompound> source;
        KanjiCompound selectedKanjiCompound;

        public ObservableCollection<KanjiCompound> KanjiCompounds { get; private set; }

        public KanjiCompound SelectedKanjiCompound
        {
            get { return selectedKanjiCompound; }
            set { if (selectedKanjiCompound != value) { selectedKanjiCompound = value; } }
        }

        //public ICommand DeleteCommand => Command<KanjiCompound>(RemoveKanjiCompound);

        public KanjiCompoundViewModel()
        {
            source = new List<KanjiCompound>();
            CreateKanjiCompoundCollection();

            SelectedKanjiCompound = KanjiCompounds[0];
            OnPropertyChanged("SelectedKanjiCompound");
        }

        void CreateKanjiCompoundCollection()
        {
            source.Add(new KanjiCompound("何", "なに", "What?"));
            KanjiCompounds = new ObservableCollection<KanjiCompound>(source);
        }

        void RemoveKanjiCompound(KanjiCompound kanjiCompound)
        {
            if (KanjiCompounds.Contains(kanjiCompound)) 
            {
                KanjiCompounds.Remove(kanjiCompound);
            }
        }

        #region INotifyPropertyChanged
        
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
