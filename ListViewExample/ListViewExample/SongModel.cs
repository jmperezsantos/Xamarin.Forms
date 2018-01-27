using System;
namespace ListViewExample
{
    public class SongModel
    {

        public String Title { get; set; }
        public String Subtitle { get; set; }
        public String Duration { get; set; }

        public DateTime PublishDate { get; set; }

        public String FormattedDateTime {
            get {
                
                return this.PublishDate.ToString("yyyy MMMMM dd");
            }
        }

        public SongModel(String title, String subtitle, String duration)
        {

            this.Title = title;
            this.Subtitle = subtitle;
            this.Duration = duration;

            this.PublishDate = DateTime.Now;
        }

        public override string ToString()
        {
            return string.Format("[SongModel: Title={0}, Subtitle={1}, Duration={2}]", Title, Subtitle, Duration);
        }
    }
}
