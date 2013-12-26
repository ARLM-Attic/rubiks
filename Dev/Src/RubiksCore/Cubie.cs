namespace RubiksCore
{
    public class Cubie
    {
        #region Properties

        public Position Position
        {
            get;
            internal set;
        }

        public RubiksColor? FrontSide
        {
            get;
            private set;
        }

        public RubiksColor? BackSide
        {
            get;
            private set;
        }

        public RubiksColor? RightSide
        {
            get;
            private set;
        }

        public RubiksColor? LeftSide
        {
            get;
            private set;
        }

        public RubiksColor? UpSide
        {
            get;
            private set;
        }

        public RubiksColor? DownSide
        {
            get;
            private set;
        }

        #endregion

        #region Methods

        public void Move(Position newPosition, Axes axisOfRotation, TurningDirection direction)
        {
            Position = newPosition;

            if(axisOfRotation == Axes.X)
            {
                RubiksColor? newFront = null;
                RubiksColor? newUp = null;
                RubiksColor? newBack = null;
                RubiksColor? newDown = null;

                if(direction == TurningDirection.ThreeoClock)
                {
                    newFront = DownSide;
                    newUp = FrontSide;
                    newBack = UpSide;
                    newDown = BackSide;
                }
                else if(direction == TurningDirection.SixoClock)
                {
                    newFront = BackSide;
                    newUp = DownSide;
                    newBack = FrontSide;
                    newDown = UpSide;
                }
                else
                {
                    newFront = UpSide;
                    newUp = BackSide;
                    newBack = DownSide;
                    newDown = FrontSide;
                }

                FrontSide = newFront;
                UpSide = newUp;
                BackSide = newBack;
                DownSide = newDown;
            }
            else if(axisOfRotation == Axes.Y)
            {
                RubiksColor? newUp = null;
                RubiksColor? newLeft = null;
                RubiksColor? newDown = null;
                RubiksColor? newRight = null;

                if(direction == TurningDirection.ThreeoClock)
                {
                    newUp = LeftSide;
                    newLeft = DownSide;
                    newDown = RightSide;
                    newRight = UpSide;
                }
                else if(direction == TurningDirection.SixoClock)
                {
                    newUp = DownSide;
                    newLeft = RightSide;
                    newDown = UpSide;
                    newRight = LeftSide;
                }
                else
                {
                    newUp = RightSide;
                    newLeft = UpSide;
                    newDown = LeftSide;
                    newRight = DownSide;
                }

                UpSide = newUp;
                LeftSide = newLeft;
                DownSide = newDown;
                RightSide = newRight;
            }
            else
            {
                RubiksColor? newFront = null;
                RubiksColor? newLeft = null;
                RubiksColor? newBack = null;
                RubiksColor? newRight = null;

                if(direction == TurningDirection.ThreeoClock)
                {
                    newFront = RightSide;
                    newLeft = FrontSide;
                    newBack = LeftSide;
                    newRight = BackSide;
                }
                else if(direction == TurningDirection.SixoClock)
                {
                    newFront = BackSide;
                    newLeft = RightSide;
                    newBack = FrontSide;
                    newRight = LeftSide;
                }
                else
                {
                    newFront = LeftSide;
                    newLeft = BackSide;
                    newBack = RightSide;
                    newRight = FrontSide;
                }

                FrontSide = newFront;
                LeftSide = newLeft;
                BackSide = newBack;
                RightSide = newRight;
            }
        }

        #endregion

        #region Methods\\Overrides

        public override bool Equals(object obj)
        {
            if(obj is Cubie)
            {
                return GetHashCode().Equals(obj.GetHashCode());
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            int positionHash = Position.GetHashCode();
            int frontSideHash = FrontSide.GetHashCode();
            int backSideHash = BackSide.GetHashCode();
            int rightSideHash = RightSide.GetHashCode();
            int leftSideHash = LeftSide.GetHashCode();
            int upSideHash = UpSide.GetHashCode();
            int downSideHash = DownSide.GetHashCode();

            return positionHash + frontSideHash * 2 + backSideHash * 3 + rightSideHash * 4 + leftSideHash * 5 + upSideHash * 6 + downSideHash * 7;
        }

        #endregion

        #region Constructors

        public Cubie(RubiksColor? frontSide, RubiksColor? backSide, RubiksColor? rightSide, RubiksColor? leftSide, RubiksColor? upSide, RubiksColor? downSide, Position postion)
        {
            FrontSide = frontSide;
            BackSide = backSide;
            RightSide = rightSide;
            LeftSide = leftSide;
            UpSide = upSide;
            DownSide = downSide;
            Position = postion;
        }

        #endregion
    }
}