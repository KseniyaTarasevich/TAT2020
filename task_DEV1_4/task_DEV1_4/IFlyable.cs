namespace task_DEV1_4
{
    interface IFlyable
    {
        void FlyTo(Coordinate newCoordinate);
        int GetFlyTime(Coordinate CurrentCoordinate, Coordinate newCoordinate);
    }
}
