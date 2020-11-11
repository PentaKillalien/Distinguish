using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
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
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
           
        }
        private string imagePath = string.Empty;
        /// <summary>
        /// 图像路径
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
        /// 加载图片
        /// </summary>
        public RelayCommand LoadImage => new RelayCommand(() =>
        {
            Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.Filter = "文本文件|*.png";
            if (dialog.ShowDialog() == true)
            {
                 ImagePath = dialog.FileName;
            }
        });

        /// <summary>
        /// 识别图片
        /// </summary>
        public RelayCommand DistinguishClip => new RelayCommand(() =>
        {
            if (string.IsNullOrEmpty(ImagePath))
            {
                MessageBox.Show("请选择图片");
            }
            else { 
                
            }
        });

        private string imageHeight = string.Empty;
        /// <summary>
        /// 图像长
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
        /// 图像宽
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
        /// 回形针面积
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
        /// 回形针X坐标
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
        /// 回形针y坐标
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
        /// 回形针个数
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