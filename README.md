# Project for the course Visual Programming : Visual Racing
# Developed by: Marija Karajanova, Damjan Avramovski

## 1. Опис на апликацијата.
Апликацијата која ја развивавме претставува игра која вклучува тркање во која што играчот ќе мора да биде претпазлив од другите возачи бидејќи истите се спремни по секоја цена да му наштетат! Трката во која учествуваат играчот и неговите противници вклучува повеќе рунди, така што во текот на секоја рунда противниците се убрзуваат паралелно со играчот и се движат од лента во лента на коловозот, пробувајќи да го спречат играчот да ја победи или воопшто заврши играта.

За целите на ова, имплементиравме дизајн на формата кој е едноставен за секој корисник, овозможувајќи му лесно да разбере како се игра играта. Играчот исто така ја има привилегијата да одбере една од 8 коли со која ќе се трка, како и да го внесе своето име за кога на крај ќе победи ( или изгуби ) да може да се види на ранг листата од тркачи. 

## 2. Упатство за употреба
Играта има релативно едноставен дизајн со цел да му овозможи на играчот да не се задева со банални менија и слично. Кога се уклучува апликацијата, се појавува Home формата.



![Home](https://github.com/Gavranot/VP_Project/assets/127050536/77cd23e8-6035-4610-bbf8-f8d54ecc1a5e)



* Копчето „Нова игра“ , како што кажува, му дозволува на корисникот да започне нова игра.
* Копчето „Продолжи“ му дозволува на корисникот да продолжи некоја претходна игра која ја има зачувано.
* Копчето со знак на звучник му дозволува на корисникот да ја изгаси или уклучи музиката.

По клик на копчето „Нова игра“, на корисникот му се прикажува нова форма во која може да внесе име и да одбере со која кола ќе се трка.



![CarPick](https://github.com/Gavranot/VP_Project/assets/127050536/4f790dc4-2e9e-4e47-9a6a-deb398432954)


Со клик на копчето „Choose!“ започнува играта.

Откако корисникот ќе ја одбере количката, му се прикажува следната форма која ја соддржи сцената каде што се одвива трката.


![RaceForm](https://github.com/Gavranot/VP_Project/assets/127050536/7b1f80c7-5223-46c2-acb7-38e548a3a389)


* Копчето „Save“ му овозможува на корисникот преку бинарна серијализација да ја зачува моменталната состојба на играта во фајл, така што при повторно подигање на играта може да се вчита и да се продолжи таа игра.
* Копчето „Start over“ му овозможува на корисникот да ја започне играта сосема од ново.
* Копчето „Sound on/off“ му овозможува на корисникот да ја изгаси или вклучи музиката.
* Копчето „Start/Stop“ му овозможува да ја паузира или продолжи тековната игра.

На крај, кога играчот ќе победи или ќе изгуби, ќе се прикаже соодветно форма каде што се рангирани сите тркачи по времето за кое ја завршиле трката.

![WinnerForm](https://github.com/Gavranot/VP_Project/assets/127050536/35489edc-4656-4fa8-b0d1-828fdc06b13c)

* Копчето „Започни нова игра“ му овозможува на корисникот да започне нова игра.
* Копчето „Заврши“ ја исклучува играта.

Доколку се случи играчот да се судри со некој од противниците, тогаш соодветно на корисникот му се покажува нова форма која што го известува за истото.

![CollisionForm](https://github.com/Gavranot/VP_Project/assets/127050536/73ae3ff3-a158-4bbd-8742-d3ee298ad416)

## 3. Податочни структури

Се користи листа многу често за целите на чување на информации во однос на тркачите. Креирани се класи со цел да се поедностави чувањето на информации за тркачите и за да биде разбирлива структурата на самата апликација.

```c#
public partial class HomeForm : Form
    {
        public static SoundPlayer Player { get; set; } = new SoundPlayer(@"../../Resources/RacingAudio.wav");
        public bool IsSoundOn { get; set; } = true;

        public HomeForm()
        {
            InitializeComponent();
            label1.BackColor = System.Drawing.Color.Transparent;

            this.BackgroundImageLayout = ImageLayout.Stretch;
            btnSound.BackgroundImageLayout = ImageLayout.Stretch;
            Player.Load();
            ConfigureSound();
        }
       

        private void HomeForm_Load(object sender, EventArgs e)
        {           
           
        }

        private void ConfigureSound()
        {
            if (IsSoundOn)
            {
                Player.PlayLooping();
                btnSound.BackgroundImage = Image.FromFile("../../Resources/sound-on.jpg");
            }
            else
            {
                Player.Stop();
                btnSound.BackgroundImage = Image.FromFile("../../Resources/sound-off.png");
            }
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            IsSoundOn = !IsSoundOn;
            ConfigureSound();
        }


        private void btnNewGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            CarPickForm carPickForm = new CarPickForm();
            carPickForm.ShowDialog();
            this.Close();
        }

        private void btnContinueGame_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Continue your game!";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open);
                IFormatter formatter = new BinaryFormatter();
                this.Hide();
                GameSceneForm continued = new GameSceneForm(formatter, fs);
                continued.ShowDialog();
                this.Close();
            }
        }
    }
```

Во Home формата се чува објект од класа SoundPlayer со цел да се вчита музиката која може да се вклучи. За секое копче е направена посебна event handler функција. ConfigureSound() функцијата се повикува при кликање на копчето со звучник со цел да се конфигурира музиката, т.е дали да почне или да се сопре.

* btnNewGame_Click функцијата претставува event handler за кликот на копче за нова игра и соодветно подигнува нова форма во која корисникот може да избере кола со која што ќе се трка.
* btnContinueGame_Click функцијата претставува event handler за клик на копчето за продолжување на некоја претходна игра и содржи логика за бинарна десеријализација на сцена, со тоа што со вчитаната сцена се подигнува формата каде играта продолжува од каде што застанала.

```c#
 public partial class CarPickForm : Form
    {
        List<String> carImagePaths;
        int currIndex;
        public String selectedCar;
        String playerName;

        public CarPickForm()
        {
            InitializeComponent();
            carImagePaths = new List<String>();
            carImagePaths.Add(@"../../Resources/carorange.png");
            String[] carNames = { "ambulance-png","cargreen-png","cargrey-png", "carpink-png", "carred-png", "truckblue-png", "truckwhite-png" };
            for(int i = 0; i< carNames.Length; i++)
            {
                carImagePaths.Add(@"../../Resources/" + carNames[i] + ".png");
            }
            currIndex = 0;

            this.BackgroundImageLayout = ImageLayout.Stretch;
            
        }

        private void CarPickForm_Load(object sender, EventArgs e)
        {
            pbPickCar.ImageLocation = carImagePaths[0];
            
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if(currIndex < carImagePaths.Count-1)
            {
                currIndex++;
                pbPickCar.ImageLocation = carImagePaths[currIndex];
                
            }
            else
            {
                currIndex = 0;
                pbPickCar.ImageLocation = carImagePaths[currIndex];
            }
            Console.WriteLine(currIndex);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (currIndex > 0)
            {
                currIndex--;
                pbPickCar.ImageLocation = carImagePaths[currIndex];
                
            }
            else
            {
                currIndex = carImagePaths.Count-1;
                pbPickCar.ImageLocation = carImagePaths[currIndex];
            }
            Console.WriteLine(currIndex);
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            selectedCar = carImagePaths[currIndex];
            if (ValidateChildren())
            {
                this.Hide();
                GameSceneForm gameSceneForm = new GameSceneForm(selectedCar, carImagePaths, playerName);
                gameSceneForm.ShowDialog();
                this.Close();
            }
        }



        private void tbName_TextChanged(object sender, EventArgs e)
        {
            playerName = tbName.Text;
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if(tbName.Text.Equals(""))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbName, "Полето не смее да биде празно!");
            }
            else
            {
                errorProvider1.SetError(tbName, null);
            }
        }
    }
```
Во CarPick формата има соодветни event handlers за секоја контрола во формата. Тоа што е битно за оваа форма е фактот што се чуваат патеките за сликите за противниците во листа како и патеката на сликата која ја избрал корисникот, со тоа што истите овие информации ќе бидат предадени потоа во GameSceneForm формата која е одговорна за започнување на играта и контролирање на настаните во неа. Со копчињата за лево и десно, се одбира од листата со слики за коли и со клик на копчето choose, се предаваат овие информации на нов објект од GameSceneForm класата.

```c#
[Serializable]
    public partial class GameSceneForm : Form
    {
        public Scene Scene { get; set; }
        public String playerCar { get; set; }
        public List<String> carPaths { get; set; }
        Random aiCarSelector = new Random();
        Random speedSelector = new Random();
        int countDownCounter = 2; //se koristi i za dvata tamjeri bidejki se nezavisni  eden od drug       
        public static int MIN_SPEED { get; set; } = 1;
        public static int MAX_SPEED { get; set; } = 8;

        public bool isUpPressed { get; set; } = false;
        public bool isLeftPressed { get; set; } = false;
        public bool isRightPressed { get; set; } = false;

        public bool IsSoundOn { get; set; } = true;


        public GameSceneForm(String playerCar, List<String> carPaths, String playerName)
        {
            InitializeComponent();
            DoubleBuffered = true;

            this.BackgroundImageLayout = ImageLayout.Stretch;

            Scene = new Scene(this.Width, this.Height,
                2,
                speedSelector.Next(MIN_SPEED, MAX_SPEED),
                speedSelector.Next(MIN_SPEED, MAX_SPEED),
                MAX_SPEED);

            this.playerCar = playerCar;
            this.carPaths = carPaths;
            Scene.PlayerPath = playerCar;
            Scene.carPaths = carPaths;

            Scene.CreatePlayer(playerCar, playerName);
            Scene.CreateLeftOpponenet(carPaths[aiCarSelector.Next(0, carPaths.Count)], "Opponent 1");
            Scene.CreateRightOpponenet(carPaths[aiCarSelector.Next(0, carPaths.Count)], "Opponent 2");

            countDownTimer.Start();
        }

        public GameSceneForm(IFormatter formatter, FileStream fs) {
            InitializeComponent();
            DoubleBuffered = true;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            Scene = (Scene)formatter.Deserialize(fs);
            raceTimer.Start();
            CarMove.Start();
            lbCountDown.Hide();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            Invalidate();
        }

        private void countDownTimer_Tick(object sender, EventArgs e)
        {
            lbCountDown.Text = $"RACE IN {countDownCounter}";
            if(countDownCounter == 2)
            {
                lbCountDown.ForeColor = Color.Orange;
                countDownCounter--;
            }
            else if(countDownCounter==1)
            {
                lbCountDown.ForeColor= Color.Yellow;
                countDownCounter--;
            }
            else if(countDownCounter==0)
            {
                lbCountDown.Text = "GO GO GO!";
                lbCountDown.ForeColor = Color.Green;              
                countDownCounter--;
            }
            else
            {
                lbCountDown.Hide();
                countDownTimer.Stop();
                raceTimer.Start();
                CarMove.Start();
            }
        }

        private void GameSceneForm_Paint(object sender, PaintEventArgs e)
        {
            Scene.Draw(e.Graphics);
        }

        private void raceTimer_Tick(object sender, EventArgs e)
        {
            Scene.timerCounter++;

            int minutes = Scene.timerCounter / 60;          
            int seconds = Scene.timerCounter % 60;

            tbRaceTime.Text = $"{minutes:00}:{seconds:00}";

            String winnersStatus = Scene.FinishGame();
            if (!winnersStatus.Equals(""))
            {
                raceTimer.Stop();
                CarMove.Stop();
                this.Hide();
                WinnerForm form = new WinnerForm(winnersStatus);
                form.ShowDialog();
                this.Close();
            }
        }

        private void lbPauseGame_Click(object sender, EventArgs e)
        {
            Scene.PauseOrStart();
            if(Scene.IsPaused)
            {
                lbPauseGame.Text = "Start";
                raceTimer.Stop();
                CarMove.Stop();
            }
            else
            {
                lbPauseGame.Text = "Stop";
                raceTimer.Start();
                CarMove.Start();
            }
        }


        private void GameSceneForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up) {
                isUpPressed = true;
            }
            if(e.KeyCode == Keys.Left)
            {
                isLeftPressed = true;
            }
            if(e.KeyCode == Keys.Right)
            {
                isRightPressed = true;
            }
            bool check = Scene.MovePlayer(e, Scene.timerCounter);
            if(check == true)
            {
                lbCountDown.Show();
                lbCountDown.Text = "Game over!";
                lbCountDown.BackColor = Color.Red;
                raceTimer.Stop();
                countDownTimer.Stop();
                CarMove.Stop();
                Scene.PauseOrStart();

                DialogResult result = MessageBox.Show("Имаше судар со противникот :( \n Дали сакаш да почнеш од почеток?", 
                    "ИГРАТА ЗАВРШИ", 
                    MessageBoxButtons.YesNo);

               if(result == DialogResult.Yes)
                {
                    String playerCar = this.playerCar;
                    List<String> carPaths = this.carPaths;
                    String name = Scene.Player.Name;
                    this.Hide();
                    GameSceneForm form = new GameSceneForm(playerCar, carPaths, name); 
                    form.ShowDialog();
                    this.Close();
                }

                return;
            }

            Invalidate();
        }

        private void GameSceneForm_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up) {
                isUpPressed = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                isLeftPressed = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                isRightPressed = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void lbCountDown_Click(object sender, EventArgs e)
        {

        }

        private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            raceTimer.Stop();
            CarMove.Stop();
            this.Hide();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save your game!";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate);
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, Scene);

            }
            this.Close();
        }

        private void startOverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String playerCar = this.playerCar;
            List<String> carPaths = this.carPaths;
            this.Hide();
            GameSceneForm form = new GameSceneForm(playerCar, carPaths, Scene.Player.Name);
            form.ShowDialog();
            this.Close();
        }

        private void soundOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsSoundOn = !IsSoundOn;
            ConfigureSound();
        }

        private void ConfigureSound()
        {
            if (IsSoundOn)
            {
                HomeForm.Player.PlayLooping();
                soundOffToolStripMenuItem.Text = "Sound off";
            }
            else
            {
                HomeForm.Player.Stop();
                soundOffToolStripMenuItem.Text = "Sound on";
            }
        }

        private void OpponentTImer_Tick(object sender, EventArgs e)
        {

            Console.WriteLine($"Opponents: {Scene.Left.Speed} and {Scene.Right.Speed}");
            Scene.opponentTimerCounter++;
            if (Scene.opponentTimerCounter % 5 == 0)
            {
                int select = speedSelector.Next(0, 50);

                if (select >= 25)
                {
                    if (Scene.Left.Speed < MAX_SPEED)
                    {
                        Scene.UpdateLeftOpponentSpeed(Scene.Left.Speed + 1);
                    }

                }
                else
                {
                    if (Scene.Right.Speed < MAX_SPEED)
                    {
                        Scene.UpdateRightOpponentSpeed(Scene.Right.Speed + 1);
                    }

                }

            }


            if ((isUpPressed || isLeftPressed || isRightPressed) && Scene.Player.Speed <= MAX_SPEED + 4)
            {
                int newSpeed = Scene.PlayerSpeed += 1;
                Scene.UpdatePlayerSpeed(newSpeed);
            }
            else if ((!isUpPressed && !isLeftPressed && !isRightPressed) && Scene.Player.Speed > MIN_SPEED)
            {
                int newSpeed = Scene.PlayerSpeed -= 1;
                Scene.UpdatePlayerSpeed(newSpeed);
            }



            bool swerve = false;
            if (speedSelector.Next(0, 50) >= 38)
            {
                swerve = true;
            }

            Scene.PauseOrStart();

            bool check = Scene.MoveOpponenets(swerve, Scene.timerCounter);
            if (check == true)
            {
                lbCountDown.Show();
                lbCountDown.Text = "Game over!";
                lbCountDown.BackColor = Color.Red;
                raceTimer.Stop();
                CarMove.Stop();
                countDownTimer.Stop();
                Scene.PauseOrStart();

                DialogResult result = MessageBox.Show("Имаше судар со противникот :( \n Дали сакаш да почнеш од почеток?",
                    "ИГРАТА ЗАВРШИ",
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    String playerCar = this.playerCar;
                    List<String> carPaths = this.carPaths;
                    String name = Scene.Player.Name;
                    this.Hide();
                    GameSceneForm form = new GameSceneForm(playerCar, carPaths, name);
                    form.ShowDialog();
                    this.Close();
                }

                return;
            }
            Invalidate();


        }
    }
```
Во GameSceneForm формата повторно има соодветни event handlers за секоја лабела ( не се искористени копчиња како контроли ). Во оваа форма се имплементирани 3 тајмери:
* Еден тајмер countdownTimer за одбројување до почеток на трката
* Еден тајмер raceTimer кој има тик од 1 секунда и кој го следи времето на тркање
* Еден тајмер CarMove ( функцијата за тик се вика OpponentTimer_Tick) кој има тик од 25 милисекунди и е одговорен за контролирање на движењето на противничките коли, нивно убрзување, убрзување на играчот и судири со играчот. Во рамките на функцијата за тик на овој тајмер, искористени се Random објекти со цел да се генерира логиката за движење на противничките коли.

Имплементирани се и event handlers за кликање и отпуштање на стрелките (GameSceneForm_KeyDown и GameSceneForm_KeyUp), кои дополнително се одговорни за движењето на играчот и проверка за колизии.
Имплементирана е и бинарна серијализација во event handler-от (saveGameToolStripMenuItem_Click) за лабелата за зачувување.

Во GameSceneForm класата се чува и инстанца од класа Scene во која е соддржана целата логика за поставување на брзината на играчот и неговите противници како и логиката за нивното поместување заедно со сите потребни проверки, кои подразбираат забрана за излегување надвор од сцената како и забрана за надминување на максималната брзина на движење.

Движењето на играчот-возач е поразлично спрема движењето на противниците бидејќи истото зависи од влез од тастатура и не од тајмер, така што има одредени вредности кои се соодветно подесени со цел да му се овозможи на играчот подобро искуство ( Максималната брзина на играчот е MAX_SPEED + 4 и при престројување исто така е побрз ).

```c#
[Serializable]
    public class Scene
    {
        public Player Player { get; set; }
        public Opponent Left { get; set; }
        public Opponent Right { get; set; }

        public static int Width { get; set; }
        public static int Height { get; set; }

        public String PlayerPath { get; set; }
        public List<String> carPaths { get; set; }
        public int timerCounter { get; set; } = 0;
        public int opponentTimerCounter { get; set; } = 0;  

        public bool IsPaused { get; set; } = true;

        public int PlayerSpeed { get; set; }
        public int LeftSpeed { get; set; }
        public int RightSpeed { get; set; }

        public static int MAX_SPEED { get; set; } = 0;
        public static int DISTANCE_FROM_BOTTOM { get; set; } = 100;

        public Random moveAI {  get; set; } = new Random();

        public List<Car> FinishedCars { get; set; } = new List<Car>();
        public bool AllFinished { get; set; } = false;



        public Scene(int width, int height, int playerSpeed, int leftSpeed, int rightSpeed, int maxSpeed)
        {
            Width = width;
            Height = height;
            PlayerSpeed = playerSpeed;
            LeftSpeed = leftSpeed;  
            RightSpeed = rightSpeed;
            MAX_SPEED = maxSpeed;
            Console.WriteLine($"Height: {height}");
        }

       

        public void CreatePlayer(String playerImagePath, String name)
        {
            Player = new Player(playerImagePath, new Point(3 * Width/7, Height - DISTANCE_FROM_BOTTOM), PlayerSpeed, name);
        }

        public void CreateLeftOpponenet(String leftOpponentImagePath, String name)
        {
            Left = new Opponent(leftOpponentImagePath, new Point(Width/7, Height - DISTANCE_FROM_BOTTOM), LeftSpeed, name);
        }

        public void CreateRightOpponenet(String rightOpponentImagePath, String name)
        {
            Right = new Opponent(rightOpponentImagePath, new Point(5 * Width/7, Height - DISTANCE_FROM_BOTTOM), RightSpeed, name);
        }

        public void Draw(Graphics g)
        {
            Player.Draw(g);
            Left.Draw(g);
            Right.Draw(g);
        }

        public void PauseOrStart()
        {
            IsPaused = !IsPaused;

        }

        public bool MoveOpponenets(bool swerve, int timeCounter)
        {
            //Console.WriteLine($"Opponents speeds : {Left.Speed} and {Right.Speed}");
           
            if (!IsPaused)
            {
                if (!Player.IsFinished && (Player.hitBox.IntersectsWith(Left.hitBox) || Player.hitBox.IntersectsWith(Right.hitBox)))
                {
                    // Console.WriteLine("Collision!");
                    return true;
                }

                if (swerve)
                {
                    int rand = moveAI.Next(0, 2);
                    if (!Left.IsFinished)
                    {
                        if (rand == 0)
                        {
                            for (int i = 0; i < 3 && Left.Location.X > Left.Image.Width-20; i++)
                            {
                                if (!Player.IsFinished && (Player.hitBox.IntersectsWith(Left.hitBox) || Player.hitBox.IntersectsWith(Right.hitBox)))
                                {
                                    // Console.WriteLine("Collision!");
                                    return true;
                                }
                                Left.OvertakeLeft();
                            }

                        }
                        else
                        {
                            for (int i = 0; i < 3 && Left.Location.X < Width - Left.Image.Width-20; i++)
                            {
                                if (!Player.IsFinished && (Player.hitBox.IntersectsWith(Left.hitBox) || Player.hitBox.IntersectsWith(Right.hitBox)))
                                {
                                    // Console.WriteLine("Collision!");
                                    return true;
                                }
                                Left.OvertakeRight();
                            }

                        }
                    }

                    if (!Right.IsFinished)
                    {
                        rand = moveAI.Next(0, 2);
                        if (rand == 0)
                        {
                            for (int i = 0; i < 3 && Right.Location.X > Right.Image.Width-20 * 2; i++)
                            {
                                if (!Player.IsFinished && (Player.hitBox.IntersectsWith(Left.hitBox) || Player.hitBox.IntersectsWith(Right.hitBox)))
                                {
                                    // Console.WriteLine("Collision!");
                                    return true;
                                }
                                Right.OvertakeLeft();
                            }

                        }
                        else
                        {
                            for (int i = 0; i < 3 && Right.Location.X < Width - Right.Image.Width-20; i++)
                            {
                                if (!Player.IsFinished && (Player.hitBox.IntersectsWith(Left.hitBox) || Player.hitBox.IntersectsWith(Right.hitBox)))
                                {
                                    // Console.WriteLine("Collision!");
                                    return true;
                                }
                                Right.OvertakeRight();
                            }

                        }
                    }
                    
                }
                else
                {
                    if (!Left.IsFinished)
                    {
                        Left.MoveUp(timeCounter);
                    }
                    if (!Right.IsFinished)
                    {
                        Right.MoveUp(timeCounter);
                    }
                   
                }

                if (Left.IsFinished && !FinishedCars.Contains(Left))
                {
                    FinishedCars.Add(Left);
                }

                if (Right.IsFinished && !FinishedCars.Contains(Right))
                {
                    FinishedCars.Add(Right);
                }

                if (Player.IsFinished && !FinishedCars.Contains(Player))
                {
                    FinishedCars.Add(Player);
                }

            }
           
            return false;

        }

        public void UpdatePlayerSpeed(int newSpeed)
        {
            PlayerSpeed = newSpeed;
            Player.Speed = newSpeed;
        }

        public void UpdateLeftOpponentSpeed(int newSpeed)
        {
            if(Left.Speed <= MAX_SPEED)
            {
                Left.Speed = newSpeed;
                LeftSpeed = newSpeed;
            }
            
        }

        public void UpdateRightOpponentSpeed(int newSpeed)
        {
            if(Right.Speed <= MAX_SPEED)
            {
                Right.Speed = newSpeed;
                RightSpeed = newSpeed;
            }
            
        }

        public bool MovePlayer(KeyEventArgs keyDown, int timeCounter)
        {
            Console.WriteLine($"Player location: {Player.Location}");

            if (!Player.IsFinished && (Player.hitBox.IntersectsWith(Left.hitBox) || Player.hitBox.IntersectsWith(Right.hitBox)))
            {
                // Console.WriteLine("Collision!");
                return true;
            }

            if (!IsPaused)
            {
              
                
                    if (keyDown.KeyCode == Keys.Up)
                    {
                        Player.MoveUp(timeCounter);
                    }
                    else if (keyDown.KeyCode == Keys.Left && Player.Location.X >= Player.Image.Width-20)
                    {
                        Player.OvertakeLeft();
                    }
                    else if (keyDown.KeyCode == Keys.Right && Player.Location.X <= Width - Player.Image.Width - 20)
                    {
                        Player.OvertakeRight();
                    }
              
            }
            return false;
            
        }

        private static int compareByFinish(Car car1, Car car2)
        {
            if(car1.FinishTime > car2.FinishTime)
            {
                return 1;
            }
            if(car1.FinishTime < car2.FinishTime)
            {
                return -1;
            }
            return 0;
        }

        public String FinishGame()
        {
            AllFinished = Player.IsFinished && Left.IsFinished && Right.IsFinished;

            StringBuilder sb = new StringBuilder();

            if (AllFinished)
            {
                FinishedCars.Sort(compareByFinish);
                for(int i = 0; i <FinishedCars.Count; i++)
                {
                    
                    int minutes = FinishedCars[i].FinishTime / 60;
                    int seconds = FinishedCars[i].FinishTime % 60;
                    sb.Append($"{i+1}. {FinishedCars[i].Name} {minutes:00}:{seconds:00}\n");
                }
            }

            return sb.ToString();
        }
    }
```
Во класата за сцена Scene, се чуваат сите потребни податоци за една кола Car како и одредени податоци за играта кои при серијализација треба да се зачувани. Car е суперкласата на класите Player и Opponent. Scene содржи соодветни методи потребни за иницијализирање на објектите со суперкласа Car при вчитување на GameSceneForm формата и како последица, дели одредени податоци со GameSceneForm класата за целите на серијализација и започнување на нови игри.

Сцената ја содржи логиката за движење на играчот и неговите противници. При секое движење се прави проверка за колизија и кај MoveOpponents дали секој од учесниците има завршено.
Во MoveOpponents функцијата конкретно се користи Random објект со чија помош се генерираат бројки врз база на кои се одлучува за секој противник дали ќе се движи лево, десно или дали само ќе продолжи право нагоре.
FinishGame() функцијата проверува дали играта е завршена и доколку условот е исполнет, конструира String во кој се содржат времињата на завршување на секој од тркачите. Листата FinishedCars се сортира со помош на private функција според времето за завршување на секој Car објект.

```c#
[Serializable]
    public class Car
    {
        public String ImagePath { get; set; }
        public Image Image { get; set; }
        public String Name { get; set; }
        public Point Location { get; set; }
        public int Speed { get; set; }


        public Rectangle hitBox { get; set; }   


        public static int NUM_ROUNDS { get; set; } = 3;
        public int Round { get; set; } = 1;
        public bool IsFinished { get; set; } = false;
        public int FinishTime { get; set; } = 0;

        public Car(String imagePath, Point location, int speed, String name)
        {
            ImagePath = imagePath;
            Image = new Bitmap(ImagePath);
            Location = location;
            Speed = speed;
            Name = name;            
        }

        public void Draw(Graphics g)
        {
            Rectangle rectangle = new Rectangle(Location.X, Location.Y - Image.Height, Image.Width, Image.Height);
            hitBox = rectangle;
            TextureBrush brush = new TextureBrush(Image);
            brush.TranslateTransform(Location.X, Location.Y - Image.Height);
 
            g.FillRectangle(brush, rectangle);
            brush.Dispose();
        }

        public void MoveUp(int timeCounter)
        {
           
            if(Round == NUM_ROUNDS + 1)
            {
                if (!IsFinished)
                {
                    Console.WriteLine($"Car: {ImagePath}, Time : {timeCounter}");
                    IsFinished = true;
                    Location = new Point(Location.X, Scene.Height - Image.Height - 10);

                    FinishTime = timeCounter;
                   
                }              
            }
            else
            {
                Location = new Point(Location.X, (Location.Y - 10) - Speed);
                if (Location.Y <= 0)
                {
                    Location = new Point(Location.X, Scene.Height);
                    Round++;
                }
            }
        }
      
    }
```
Во класата Car се чуваат податоци за патеката за слика за конкретниот објект, самата слика, името, локацијата и брзината на објектот. Дополнително се чува HitBox кој се користи за целите на колизија и има соодветно прилагодени димензии. Се чуваат максималниот број на рунди во трката, во која рунда се наоѓа објектот во моментот, дали е завршен со трката и времето кога завршил. Во Draw функцијата се креира објектот кој треба да се прикаже на екран во форма на правоаголник, со тоа што истиот правоаголник кој се прикажува на екранот се поставува и да биде HitBox на објектот. Место боја, преку TextureBrush се нанесува текстурата на објектот.

Во MoveUp функцијата се прават 2 работи :
* Проверка дали објектот завршил и зачувување на времето на завршување
* Движење на објектот и проверка дали ја надминал горната граница на формата со цел да се започне нова рунда за тој објект

Класите Opponent и Player наследуваат од оваа класа и единствено имплементираат методи за движење лево и десно дијагонално.
