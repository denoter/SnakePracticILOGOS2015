using UnityEngine;
using System.Collections;
/* Скрипт управления меню содержит функции, которые выполняются в кнопках через UIButtonMessage */
public class ControlMenu : MonoBehaviour {
	public static int isCameraChanged = 1; // переменная для проверки включенной камеры false = 3d, true = 2d;
	public UILabel cameraInfoLabel;
	// Use this for initialization
	void playgame () {
		Application.LoadLevel ("PlayMenu");
		GameManager.lives = 3;
		GameManager.points = 0;
		GameManager.size = 0;
	}
	
	// Update is called once per frame
	void exitgame () { // функция выхода из игры
		Application.Quit ();
	}
	void changeCamera () { 
		// функция перекючения камеры, изменяет значение переменной при нажатии кнопки 
		// дальше используется в CameraChanger для самого переключения
		if (isCameraChanged == 0) {
			isCameraChanged = 1;	
			// 3d label
			cameraInfoLabel.text = "CAMERA : 3D";
		} else {
			cameraInfoLabel.text = "CAMERA : 2D";
			isCameraChanged = 0;
			//2d label

		}
	}
	void easylevel () { // загрузка первого уровня
		Application.LoadLevel ("MainScene");
	}
	void hardlevel () { // загрузка уровня сложнее
		Application.LoadLevel ("MainScene 1");
	}
	void getback () { // назад в главное меню
		Application.LoadLevel ("MainMeniNGUI");
	}


}
