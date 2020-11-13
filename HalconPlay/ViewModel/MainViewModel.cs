using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using HalconPlay.Model;
using System.Windows;

namespace HalconPlay.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        
        public ClipData clipData { get; set; }
        public MainViewModel()
        {
            clipData = new ClipData();
        }
        private string imagePath = string.Empty;
        /// <summary>
        /// ͼ��·��
        /// </summary>
        public string ImagePath
        {
            get { return imagePath; }
            set
            {
                imagePath = value;
                this.RaisePropertyChanged(nameof(ImagePath));
            }
        }

        /// <summary>
        /// ����ͼƬ
        /// </summary>
        public RelayCommand LoadImage => new RelayCommand(() =>
        {
            Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.Filter = "�ı��ļ�|*.png";
            if (dialog.ShowDialog() == true)
            {
                 ImagePath = dialog.FileName;
            }
        });

        /// <summary>
        /// ʶ��ͼƬ
        /// </summary>
        public RelayCommand DistinguishClip => new RelayCommand(() =>
        {
            if (string.IsNullOrEmpty(ImagePath))
            {
                MessageBox.Show("��ѡ��ͼƬ");
            }
            else {
                HDevelopExport hde = new HDevelopExport(ImagePath);
                clipData=  hde.RunHalcon(hde.hv_ExpDefaultWinHandle);
            if (clipData != null) {
                    ImageHeight = clipData.ImageHeight;
                    ImageWidth = clipData.ImageWidth;
                    ClipAreas = clipData.ClipAreas;
                    ClipXs = clipData.ClipXs;
                    ClipYs = clipData.ClipYs;
                    ClipCount = clipData.ClipCount;
                
                }
            }
        });

        private string imageHeight = string.Empty;
        /// <summary>
        /// ͼ��
        /// </summary>
        public string ImageHeight
        {
            get { return imageHeight; }
            set
            {
                imageHeight = value;
                this.RaisePropertyChanged(nameof(ImageHeight));
            }
        }
        private string imageWidth = string.Empty;
        /// <summary>
        /// ͼ���
        /// </summary>
        public string ImageWidth
        {
            get { return imageWidth; }
            set
            {
                imageWidth = value;
                this.RaisePropertyChanged(nameof(ImageWidth));
            }
        }

        private string clipAreas = string.Empty;
        /// <summary>
        /// ���������
        /// </summary>
        public string ClipAreas
        {
            get { return clipAreas; }
            set
            {
                clipAreas = value;
                this.RaisePropertyChanged(nameof(ClipAreas));
            }
        }
        private string clipXs = string.Empty;
        /// <summary>
        /// ������X����
        /// </summary>
        public string ClipXs
        {
            get { return clipXs; }
            set
            {
                clipXs = value;
                this.RaisePropertyChanged(nameof(ClipXs));
            }
        }
        private string clipYs = string.Empty;
        /// <summary>
        /// ������y����
        /// </summary>
        public string ClipYs
        {
            get { return clipYs; }
            set
            {
                clipYs = value;
                this.RaisePropertyChanged(nameof(ClipYs));
            }
        }

        private string clipCount = string.Empty;
        /// <summary>
        /// ���������
        /// </summary>
        public string ClipCount
        {
            get { return clipCount; }
            set
            {
                clipCount = value;
                this.RaisePropertyChanged(nameof(ClipCount));
            }
        }

    }
}