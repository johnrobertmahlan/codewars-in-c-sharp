public class Dinglemouse {

  public static int[] humanYearsCatYearsDogYears(int humanYears) {
    if (humanYears == 1)
    {
      int catYears = 15;
      int dogYears = 15;

      return new int[]{humanYears, catYears, dogYears};
    }
    else if (humanYears == 2)
    {
      int catYears = 24;
      int dogYears = 24;

      return new int[]{humanYears, catYears, dogYears};
    }
    else
    {
      int yearsPastTwo = humanYears - 2;

      int catYears = 24 + (yearsPastTwo * 4);
      int dogYears = 24 + (yearsPastTwo * 5);

      return new int[]{humanYears, catYears, dogYears};
    }

  }

}