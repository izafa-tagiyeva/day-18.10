using ConsoleApp1;




/*  Weapon deyə class yaradılır.
Darağın güllə tutumu, Daraqdakı güllə sayı,atış modu(təkli və ya avtomatik) propertileri verilir.
Shoot() -  metodu hər çağırıldıqda fire moduna gore ya 1 güllə atır yada avtomatik gulleni bosaldir.(Ekranda bunu bildirir)
GetRemainBulletCount() - darağın tam dolması üçün lazım olan güllə sayını qaytarır.
Reload() - darağı yenidən doldurur.
ChangeFireMode() - Atış modunu dəyişir.
Bütün məlumatları doldurmadan obyekt yaratmaq olmasın.
0 - İnformasiya almaq üçün
1 - Shoot metodu üçün
2 - GetRemainBulletCount metodu üçün
3 - Reload metodu üçün
4 - ChangeFireMode metodu üçün
5 - Proqramdan dayandırmaq üçün qısayoldur.*/






            Weapon new_gun = new Weapon();
            Console.WriteLine("tutumu daxil edin");
            int tutum = int.Parse(Console.ReadLine());
            Console.WriteLine("say daxil edin");
            int say = int.Parse(Console.ReadLine());
            Console.WriteLine("atis modun teyin edin.tekli modu ucun true yazsin daxil edin,umumi atim ucun false yazisin daxil edin");
            bool atis_modu = bool.Parse(Console.ReadLine());
            new_gun = new Weapon(tutum, say, atis_modu);




int choiche;
do
{
    Console.WriteLine("0 - İnformasiya almaq üçün\r\n 1 - Shoot metodu üçün\r\n  2 - GetRemainBulletCount metodu üçün\r\n 3 - Reload metodu üçün\r\n   4 - ChangeFireMode metodu üçün\r\n 5 - Proqramdan dayandırmaq üçün");
    choiche = int.Parse(Console.ReadLine());


    
    switch (choiche)
    {
        case 0:
            new_gun.GetInfo(tutum,say,atis_modu);
            break;
        case 1:
            new_gun.Shoot(new_gun.atis_modu);
            break;
        case 2:
            Console.WriteLine($"Daragin tam dolmasi ucun lazim olan gulle sayi:{new_gun.GetRemainBulletCount(new_gun.say, new_gun.tutum)}");
            break;
        case 3:
            new_gun.say = new_gun.Reload();
            Console.WriteLine("darağı yenidən dolduruldu");
            break;
        case 4:
            new_gun.atis_modu = new_gun.ChangeFireMode(new_gun.atis_modu);
            Console.WriteLine("atis modu deyisdirildi");
            break;
        case 5:
            Console.WriteLine("Exiting..");
            break;

        default:
            Console.WriteLine("invalid option");
            break;

    }
} while (choiche != 5);