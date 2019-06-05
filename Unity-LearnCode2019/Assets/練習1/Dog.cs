//1. 請在 .NET 小提琴 新增一個頁面
//2. 定義一個測試類別，包含程式入口 (Main 方法)
//3. 定義一個狗類別
//4. 狗類別包含欄位 (請使用適當的型別)
//    - 名稱
//    - 體重
//    - 品種
//    - 性別
//    - 顏色
//    - 年齡
//5. 狗類別包含方法
//    - 叫 - 無回傳並輸出狗狗名稱：汪汪訊息
//    - 轉換人類年齡 - 回傳年齡 * 7 (狗換算為人類年齡)
//    - 吃東西 - 設定兩個參數，第一個為食物，第二個為吃飯速度預設值為慢，輸出訊息：狗狗名稱正在吃”食物”，速度為”吃飯速度”
//    - 吃東西 - 多載方法，設定兩個參數，第一個為食物，第二個為份量整數，輸出訊息：狗狗名稱正在吃"食物"，份量：”份量”
//6. 在 Main 方法內產生兩個狗物件
//    - 賦予名稱、體重、品種、性別、顏色與年齡
//    - 輸出兩個狗的名稱、品種、顏色 (在同一行)
//7. 在 Main 方法內執行兩個狗物件的叫方法
//8. 在 Main 方法內執行兩個狗物件的轉換人類年齡方法並輸出轉換後的年齡
//9. 在 Main 方法內執行第一個狗物件的吃東西方法，傳入食物
//10. 在 Main 方法內執行第二個狗物件的吃東西方法，傳入食物與份量
/*/用"/*//*/"這個方式大範圍註記文章/*/
using UnityEngine;
[System.Serializable]
public class Dog 


{
    #region 欄位
    public string name;
    public float weight;
    
    public string color;

    private string sex;
    private int age;
    private string type;
    #endregion

    #region 建構函式

    //建構函式可以多載
    public Dog()
    {

    }

    public Dog(string sex, int age, string type )
    {
        this.sex = sex;
        this.age = age;
        this.type = type;
    }
    #endregion

    #region 方法
    /// <summary>
    /// 狗狗叫聲
    /// </summary>
    public void Bark()
    {
        Debug.Log(name + ":汪汪!!!");
    }

    /// <summary>
    /// 狗與人類年齡轉換
    /// </summary>
    /// <returns>狗年齡 * 7</returns>
    public int ConvertAge()
    {
        return age * 7;
    }
    /// <summary>
    /// 狗吃東西的方法
    /// </summary>
    /// <param name="food">食物</param>
    /// <param name="speed">吃飯速度</param>
    public void Eat(string food, string speed = "慢")
    {
        Debug.Log(name + ":" + food + "，速度：" + speed);
    }

    public void Eat(string food, int count)
    {
        Debug.Log(name + ":" + food + "，份量：" + count);
    }
    #endregion


}