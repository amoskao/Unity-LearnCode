using UnityEngine;

#region 欄位
public class DogManager : MonoBehaviour
{
    public Dog DogA = new Dog("公", 7, "杜賓狗");
    public Dog DogB = new Dog("母", 3, "吉娃娃");
    public Dog DogC = new Dog( );
    #endregion

    #region 事件
    private void Start( )
    {
        DogA.name = " 黑老大 ";
        DogA.weight = 30.5f;
        //DogA.type = " 杜賓狗 ";
        /*DogA.sex = " 公 ";*/
        DogA.color = " 黑色 ";
        //DogA.age = 7;

        DogB.name = " 毛小弟 ";
        DogB.weight = 10.5f;
        //DogB.type = " 吉娃娃 ";
        /*DogB.sex = " 公 ";*/
        DogB.color = " 黃色 ";
        //DogB.age = 4;

        Debug.Log(DogA.name + " 品種: " + DogA.type + " 顏色: " + DogA.color);
        Debug.Log(DogB.name + " 品種: " + DogB.type + " 顏色: " + DogB.color);

        DogA.Bark();
        DogB.Bark();

        Debug.Log(DogA.name +"的實際年齡為：" +  DogA.ConvertAge());
        Debug.Log(DogB.name +"的實際年齡為：" +  DogB.ConvertAge());

        DogA.Eat("熱狗");
        DogB.Eat("蛋糕",10);
    }
    #endregion
}