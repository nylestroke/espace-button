namespace EscapeButton
{
    public partial class MainWindow : Form
    {
        readonly Random random;
        int points = 0;

        /// <summary>
        /// Constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            random = new Random();
            gameTimer.Start(); // Start a timer on window initialize

        }

        /// <summary>
        /// Function which moves the button
        /// </summary>
        private void moveButton()
        {
            // Screen variables
            int maxX = this.Size.Width - escapeButton.Size.Width - 28; // Screen width 
            // Screen height (removed 28 pixels from height, cause footer's height is 25px + 3 px extra)
            int maxY = (this.Size.Height - 28) - escapeButton.Size.Height - 28;

            Point point = new()
            {
                X = random.Next(28, maxX),
                Y = random.Next(28, maxY)
            };

            escapeButton.Location = point;
        }

        /// <summary>
        /// Function which restart timer
        /// </summary>
        private void restartTimer()
        {
            gameTimer.Stop();
            gameTimer.Start();
        }

        /// <summary>
        /// Function which updates the score
        /// </summary>
        /// <param name="status">Score status (if true -> incrementing score)</param>
        private void updateScore(bool status)
        {
            if (status is true) // Check for status (true indicate button click)
            {
                points++;
            }
            else
            {
                points = 0;
            }

            // Update score in label
            scoreLabel.Text = $"Score: {points}";
        }

        /// <summary>
        /// Handler for screen button
        /// </summary>
        /// <param name="sender">Interapted object</param>
        /// <param name="e">Interapted event</param>
        private void escapeButton_Click(object sender, EventArgs e)
        {
            moveButton(); // Move button if button is clicked
            updateScore(true); // Increment the points
            restartTimer();
        }

        /// <summary>
        /// Handler for game ticker
        /// </summary>
        /// <param name="sender">Interapted object</param>
        /// <param name="e">Interapted event</param>
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            moveButton(); // Move button every tick (1 second)
            updateScore(false); // Reset score if button is not clicked
        }
    }
}