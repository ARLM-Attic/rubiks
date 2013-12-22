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

        public void Move(Position beginPosition, Position endPosition)
        {
            throw new System.NotImplementedException();
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
        }

        #endregion
    }
}