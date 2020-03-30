namespace task_DEV1_4
{
    interface IFlyable
    {
        void FlyTo(Coordinate newCoordinate);
        float GetFlyTime(Coordinate CurrentCoordinate, Coordinate newCoordinate);
    }
}
