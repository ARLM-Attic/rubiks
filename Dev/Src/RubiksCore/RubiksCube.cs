namespace RubiksCore
{
    public class RubiksCube
    {
        #region Properties

        public Cubie this[int x, int y, int z]
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        #endregion

        #region Methods \\ Basic Moves

        public void TurnFront(TurningDirection direction = TurningDirection.ThreeoClock)
        {
            throw new System.NotImplementedException();
        }

        public void TurnBack(TurningDirection direction = TurningDirection.ThreeoClock)
        {
            throw new System.NotImplementedException();
        }

        public void TurnRight(TurningDirection direction = TurningDirection.ThreeoClock)
        {
            throw new System.NotImplementedException();
        }

        public void TurnLeft(TurningDirection direction = TurningDirection.ThreeoClock)
        {
            throw new System.NotImplementedException();
        }

        public void TurnUp(TurningDirection direction = TurningDirection.ThreeoClock)
        {
            throw new System.NotImplementedException();
        }

        public void TurnDown(TurningDirection direction = TurningDirection.ThreeoClock)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        #region Methods \\ Turning the entire cube

        public void TurnCubeOnX(TurningDirection direction = TurningDirection.ThreeoClock)
        {
            throw new System.NotImplementedException();
        }

        public void TurnCubeOnY(TurningDirection direction = TurningDirection.ThreeoClock)
        {
            throw new System.NotImplementedException();
        }

        public void TurnCubeOnZ(TurningDirection direction = TurningDirection.ThreeoClock)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        #region Methods \\ Generic Turning Methods

        public void Turn(string turnNotation)
        {
            throw new System.NotImplementedException();
        }

        public void Turn(RubiksDirection side, TurningDirection direction = TurningDirection.ThreeoClock, int numberOfLayersDeep = 0)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        #region Constructors

        public RubiksCube(INotationParser parser, int cubeSize = 3)
        {
        }

        #endregion

        #region Methods \\ Helpers

        private Position DetermineNewPositionForCubie(Cubie cubie, RubiksDirection rotatingFace, TurningDirection turningDirection)
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}

