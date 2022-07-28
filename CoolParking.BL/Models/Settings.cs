// TODO: implement class Settings.
//       Implementation details are up to you, they just have to meet the requirements of the home task.

public static class Setting
{
    public static decimal Balance { get; set; } = 0;
    public static int Capacity { get; set; } = 10;
    public static int WithdrawTimer { get; set; } = 5; //Період списання оплати, N-секунд
    public static int LogTimer { get; set; } = 60; //Період запису у лог, N - секунд
    public static double TariffPassengerCar { get; set; } = 2;
    public static double TariffMotorcycle { get; set; } = 1;
    public static double TariffTruck { get; set; } = 5;
    public static double TariffBus { get; set; } = 3.5;
    public static double Penalty { get; set; } = 2.5;
}