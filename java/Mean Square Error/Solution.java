import java.util.*;

public class Solution {
  public static double solution(int[] arr1, int[] arr2) {


  	ArrayList<Double> arr = new ArrayList<>();
  	int sum    = 0;
  	double output = 0;

  	for (int i = 0; i < arr1.length; i++) {
  		arr.add(Math.pow(arr1[i] - arr2[i], 2));
  	}

  	for (double i : arr) {
  		output += i;
  	}

  	// debug
  	// System.out.println(arr);

    return (output / arr.size());
  }

  public static void main(String[] args) {
  	
  	int[] arr1 = {10, 20, 10, 2};
    int[] arr2 = {10, 25, 5, -2};

    System.out.println(Program.solution(arr1, arr2));

  }
}