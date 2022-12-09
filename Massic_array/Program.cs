 
 
 
 int Max(int arg1, int arg2, int arg3)
 {
    int result = arg1;
    if(arg2> result) result = arg2;
    if(arg3> result) result = arg3;
    return result;
 }
 
 
 //             0, 1, 2, 3 ....8- indexi c massive poslednii index ne 9 a 8 tk na4inaetsia s 0
int[] array = {11,22,3,42,45,64,7,8,9}; // initiatia massiva

//array[0] = 712; // tak sapisivaiutsia ismeneniia v element massiva
//Console.WriteLine(array[0]);  // tak vivod na ekran elementa massiva

int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[4], array[5], array[6]),
    Max(array[6], array[7], array[8])
 );
 //Console.Write("dop text bliaaat"); Console.WriteLine(result);  - v odnu stroku
 Console.WriteLine(result);