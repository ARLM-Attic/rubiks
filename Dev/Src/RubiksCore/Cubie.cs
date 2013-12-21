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

        #region Constructors

        public Cubie(RubiksColor? frontSide, RubiksColor? backSide, RubiksColor? rightSide, RubiksColor? leftSide, RubiksColor? upSide, RubiksColor? downSide, Position postion)
        {
        }

        #endregion
    }
}