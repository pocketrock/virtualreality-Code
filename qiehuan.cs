using UnityEngine;
using System.Collections;
using System.IO ;
using UnityEngine.UI;
using System;
using System.Text;
using UnityEditor;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Globalization;
using UnityEngine.SceneManagement;




public class qiehuan : MonoBehaviour
{ 

	public GameObject[] chuxian = new GameObject[36];
	public GameObject[] weizhi = new GameObject[16];

	public int[] numay123 = new int[55]{1,1,0,0,0,0,0,0,0,0,
		0,0,0,0,0,0,0,0,0,1,
		1,1,1,1,1,1,1,1,1,1,
		1,1,1,1,1,1,1,1,1,1,
		1,1,1,1,1,1,1,1,1,1,
		1,1,1,1,1
	};

	public int [] nummm=new int[36]{0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18 ,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35};
	public List <int> quchu= new List<int>();



	public int index = 0;
	public  string f0="222"; 
	public  string aaaaa="55";

	private float timerr=18f ;
	private bool ppp=true;
	private bool kaishiyunxing = false;
	private bool  kongzhi=true;
	private bool kai1=false;
	private bool diyi = true;
	private bool kaishi = false;
	private bool zhenshi = true;
	public static bool qiehh=false;
	public GameObject xiaoshi;
	public GameObject fduUber;

	public GameObject qiehuan1111;

	public GameObject Text;
	public GameObject Text1;
	public string pathh;
	public int zuixiao = 444;



	public int cishushu=0;



	public int dx0;
	public int dx1;
	public int dx2;
	public int dx3;
	public int dx4;
	public int dx5;
	public int dx6;
	public int dx7;



	void start()
	{  
		if (pathh == null) 
		{
			pathh = "Record.txt";


		}



	}


	void Update ()
	{

		if ((Input.GetButtonDown ("Xbox+X")|| Input.GetKeyDown (KeyCode.P)) && ppp )
		//if (Input.GetKeyDown (KeyCode.P) && ppp)	
		{


			for (int i = 8; i < numay123.Length; i++)
			{
				int temp = numay123[i];
				int randomIndex = UnityEngine.Random.Range (8, numay123.Length);
				numay123[i] = numay123[randomIndex];
				numay123[randomIndex] = temp;
			}


			for (int i = 8; i < nummm.Length; i++)
			{
				int temp = nummm[i];
				int randomIndex = UnityEngine.Random.Range (0, nummm.Length);
				nummm[i] =nummm[randomIndex];
				nummm[randomIndex] = temp;
			}
			ppp = false;

			xiaoshi.SetActive (false);
			qiehuan1111.SetActive (true);
			kaishiyunxing = true;
			kaishi = true;

		}


		if(cishushu>35)
		{

			kaishi = false;
		}

		if (timerr > 0 && kaishi ) 
		{

			if (kaishiyunxing) {
				timerr -= Time.deltaTime;

			}



			if (timerr > 16.5 )

			{
				GameObject container = GameObject.Find("Container");

				for(int j = 0; j < container.transform.childCount; j++)
				{

					foreach (Transform child in container.transform.GetChild (j).gameObject.transform)
					{
						if (child.gameObject.GetComponent<SphereCollider> () != null) 
						{

							Destroy(child.gameObject.GetComponent<SphereCollider>());
						}


						//child.gameObject.GetComponent<SphereCollider> ().enabled = false;
					}
				}

				GameObject inds = GameObject.FindGameObjectWithTag ("444");
				if (inds != null) 
				{
					Destroy (inds);
				}

				fduUber.SetActive (true);




				for(int j = 0; j < fduUber.transform.childCount; j++)
				{


					if(fduUber.transform.GetChild (j).gameObject.GetComponent<MeshRenderer> ().material.color.a<255)
					{
						fduUber.transform.GetChild (j).gameObject.GetComponent<MeshRenderer> ().material.color=new Color(0,0,0,fduUber.transform.GetChild 
							(j).gameObject.GetComponent<MeshRenderer> ().material.color.a + Time.deltaTime );
					}


				}




				Text.GetComponent<TextMesh> ().text = " ";

				Text1.GetComponent<TextMesh> ().text = " ";
			}



			if (timerr > 15  && timerr <16.5)

			{

				fduUber.SetActive (true);




				for(int j = 0; j < fduUber.transform.childCount; j++)
				{



					if (fduUber.transform.GetChild 
						(j).gameObject.GetComponent<MeshRenderer> ().material.color.a > 0) 
					{
						fduUber.transform.GetChild 
						(j).gameObject.GetComponent<MeshRenderer> ().material.color = new Color (0, 0, 0, fduUber.transform.GetChild 
							(j).gameObject.GetComponent<MeshRenderer> ().material.color.a - Time.deltaTime );
					}


				}




				Text.GetComponent<TextMesh> ().text = " ";

				Text1.GetComponent<TextMesh> ().text = " ";
			}

			if (timerr <= 15 && timerr > 0 && !kongzhi) 
			{

				GameObject container = GameObject.Find("Container");

				for(int j = 0; j < container.transform.childCount; j++)
				{

					foreach (Transform child in container.transform.GetChild (j).gameObject.transform)
					{

						if (child.gameObject.GetComponent<SphereCollider> () != null) 
						{

							Destroy(child.gameObject.GetComponent<SphereCollider>());
						}


					}
				}



				fduUber.SetActive (false);



				kaishiyunxing = false;



				Text.GetComponent<TextMesh> ().text = " ";

				Text1.GetComponent<TextMesh> ().text = " ";
				//Text1.GetComponent<TextMesh> ().text = timerr.ToString ("f0");
			}


			if (timerr <= 15 && timerr > 0 && kongzhi) 
			{


				GameObject container = GameObject.Find("Container");

				for(int j = 0; j < container.transform.childCount; j++)
				{

					foreach (Transform child in container.transform.GetChild (j).gameObject.transform)
					{

						//Destroy(child.gameObject.GetComponent<SphereCollider>());

						if (child.gameObject.GetComponent<SphereCollider> () == null)
						{
							child.gameObject.AddComponent<SphereCollider> ();
							child.gameObject.GetComponent<SphereCollider> ().enabled = true;

						}



					}
				}



				fduUber.SetActive (false);

				kaishiyunxing = true;



				Text.GetComponent<TextMesh> ().text = " ";

				Text1.GetComponent<TextMesh> ().text = " ";


				//Text1.GetComponent<TextMesh> ().text = timerr.ToString ("f0");
				kai1 = true;
			}



		}


		if ((timerr < 0) ) 
		{

			if (kai1)
			{

				Text.GetComponent<TextMesh> ().text = " ";
				Text1.GetComponent<TextMesh> ().text = " ";

				timerr = 18f;

				cishushu++;
				diyi = true;
				kai1 = false;

			}

		}


		if (numay123 [cishushu] == 0  && timerr <16.5 && kaishi ) 
		{

			if (diyi) 
			{
				diyi = false;
				duqqu ();

				yandongshichang ();

				zhenshi = true;
			}


			if(Input.GetButtonDown("X360_X")&& zhenshi )
			//if (Input.GetKeyDown (KeyCode.L) && zhenshi )
			{      


				if(qiehh)
				{

					duww ();

					if (aaaaa == f0)
					{ 	


						//	Text.GetComponent<MeshRenderer> ().enabled = true;
						Text.GetComponent<TextMesh> ().text = "Changed";
						StartCoroutine (xinxiyes());





						FileStream recordingFile = new FileStream(@"" + pathh, 
							FileMode.OpenOrCreate);
						StreamWriter sw = new StreamWriter(recordingFile);
						sw.Write(Environment.NewLine);
						sw.BaseStream.Seek(0, SeekOrigin.End);

						sw.Write(cishushu + "正确 ");



						float spendtime = 18 - timerr;

						int minute = (int)(spendtime / 60);
						int Second = (int)(spendtime - minute*60);
						int miliis=(int)( (spendtime-(int)spendtime)*1000);

						sw.Write(string.Format("{0:D2}:{1:D2}:{2:D2}",minute,Second,miliis 
							+ " "));


						sw.Write(aaaaa +" ");

						sw.Write(f0 +" ");
						sw.Flush();
						sw.Close();

						//	StartCoroutine (jixu ());

						//zhenshi = false;
						//	kongzhi = true;

						//	smi1.chuchuchu = true;


					} else {


						//	Text.GetComponent<MeshRenderer> ().enabled = true;

						Text.GetComponent<TextMesh> ().text = "Changed";
						StartCoroutine (xinxiyes());



						FileStream recordingFile = new FileStream(@"" + pathh, 
							FileMode.OpenOrCreate);
						StreamWriter sw = new StreamWriter(recordingFile);
						sw.Write(Environment.NewLine);
						sw.BaseStream.Seek(0, SeekOrigin.End);

						sw.Write(cishushu+ "错误 ");


						float spendtime = 18 - timerr;

						int minute = (int)(spendtime / 60);
						int Second = (int)(spendtime - minute*60);
						int miliis=(int)( (spendtime-(int)spendtime)*1000);

						sw.Write(string.Format("{0:D2}:{1:D2}:{2:D2}",minute,Second,miliis 
							+ " "));

						sw.Write(aaaaa +" ");

						sw.Write(f0 +" ");

						sw.Flush();
						sw.Close();

						//StartCoroutine (jixu ());
						//zhenshi = false;
						//	kongzhi = true;


						//	smi1.chuchuchu = true;

					}

					qiehh = false;

				}



			}


		}


		if (numay123 [cishushu] == 1 && timerr <16.5 && kaishi ) 
		{


			if (diyi) 
			{
				diyi = false;
				duqqu ();
				yandongshichang ();
				shengchengwuti ();
				index++;

				zhenshi = true;
			}



			if(Input.GetButtonDown("X360_X")&& zhenshi )
			//if (Input.GetKeyDown (KeyCode.L) && zhenshi )
			{      


				if(qiehh)
				{

					duww ();

					if (aaaaa == f0)
					{ 	


						//	Text.GetComponent<MeshRenderer> ().enabled = true;
						Text.GetComponent<TextMesh> ().text = "Changed";
						StartCoroutine (xinxiyes());





						FileStream recordingFile = new FileStream(@"" + pathh, 
							FileMode.OpenOrCreate);
						StreamWriter sw = new StreamWriter(recordingFile);
						sw.Write(Environment.NewLine);
						sw.BaseStream.Seek(0, SeekOrigin.End);

						sw.Write(cishushu + "正确 ");



						float spendtime = 18 - timerr;

						int minute = (int)(spendtime / 60);
						int Second = (int)(spendtime - minute*60);
						int miliis=(int)( (spendtime-(int)spendtime)*1000);

						sw.Write(string.Format("{0:D2}:{1:D2}:{2:D2}",minute,Second,miliis 
							+ " "));


						sw.Write(aaaaa +" ");

						sw.Write(f0 +" ");
						sw.Flush();
						sw.Close();

						//	StartCoroutine (jixu ());

						//zhenshi = false;
						//	kongzhi = true;

						//	smi1.chuchuchu = true;


					} else {


						//	Text.GetComponent<MeshRenderer> ().enabled = true;

						Text.GetComponent<TextMesh> ().text = "Changed";
						StartCoroutine (xinxiyes());



						FileStream recordingFile = new FileStream(@"" + pathh, 
							FileMode.OpenOrCreate);
						StreamWriter sw = new StreamWriter(recordingFile);
						sw.Write(Environment.NewLine);
						sw.BaseStream.Seek(0, SeekOrigin.End);

						sw.Write(cishushu+ "错误 ");


						float spendtime = 18 - timerr;

						int minute = (int)(spendtime / 60);
						int Second = (int)(spendtime - minute*60);
						int miliis=(int)( (spendtime-(int)spendtime)*1000);

						sw.Write(string.Format("{0:D2}:{1:D2}:{2:D2}",minute,Second,miliis 
							+ " "));

						sw.Write(aaaaa +" ");

						sw.Write(f0 +" ");

						sw.Flush();
						sw.Close();

						//StartCoroutine (jixu ());
						//zhenshi = false;
						//	kongzhi = true;


						//	smi1.chuchuchu = true;

					}

					qiehh = false;

				}



			}






		}










	}
	void duww()
	{

		//FileStream fs = new FileStream (@"" + pathh, FileMode.Open, FileAccess.Read);

		FileStream fs = new FileStream (Application.dataPath + "/List.txt", FileMode.Open, 
			FileAccess.Read);

		StreamReader sr = new StreamReader (fs, Encoding.Default);
		string st = string.Empty;

		while (!sr.EndOfStream)
		{
			st = sr.ReadLine ();

		}

		string[] ss = st.Split (new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

		int[] m = new int[ss.Length]; 

		for (int j = 0; j < ss.Length; j++) 
		{  

			m [j] = int.Parse (ss [j]);

		}

		int a = m [0]; 

		aaaaa=a.ToString();

		fs.Close ();
		sr.Close ();
		sr.Dispose ();  


	}

	IEnumerator xinxiyes()
	{

		yield return new WaitForSeconds (1f);
		Text.GetComponent<TextMesh>().text=" ";
	}


	void shengchengwuti ()
	{

		print (9999999);
		GameObject instance022 = (GameObject)Instantiate (chuxian[nummm[index]], weizhi[zuixiao].transform.position, chuxian[nummm[index]].transform.rotation);
		instance022.tag="444";


		FileStream recordingFile = new FileStream(@"" + pathh, FileMode.OpenOrCreate);
		StreamWriter sw = new StreamWriter(recordingFile);
		sw.Write(Environment.NewLine);
		sw.BaseStream.Seek(0, SeekOrigin.End);
		sw.Write(cishushu + "出现物体 ");
		sw.Write (chuxian[nummm[index]].name + " ");

		sw.Flush();
		sw.Close();


	}

	void duqqu()
	{

		quchu.Clear ();

		FileStream fs = new FileStream (Application.dataPath + "/quan.txt", FileMode.Open, 
			FileAccess.Read);
		//FileStream fs = new FileStream (@"" + path, FileMode.Open, FileAccess.Read);
		StreamReader sr = new StreamReader (fs, Encoding.Default);
		string st = string.Empty;

		while (!sr.EndOfStream) {
			st = sr.ReadLine ();

		}

		string[] ss = st.Split (new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);




		int[] m = new int[ss.Length]; 


		for (int j = 0; j < ss.Length; j++) 
		{  

			m [j] = int.Parse (ss [j]);

		}




		dx0 = m [0];
		dx1 = m [1];
		dx2 = m [2];
		dx3 = m [3];
		dx4 = m [4];
		dx5 = m [5];
		dx6 = m [6];
		dx7 = m [7];



		int a = m [0]; 





		for (int kkk = 0; kkk < m.Length; kkk++)
		{ 
			if (a <= m [kkk]) { 
				a = m [kkk]; 
			} 
		}  

		for (int kk = 0; kk < m.Length; kk++) { 
			//	if (a >= m [kk] & m [kk] != 0)

			if (a >= m [kk])
			{ 
				a = m [kk]; 
			} 
		}  



		for (int ii = 0; ii < m.Length; ii++) 
		{

			if (m [ii] == a) 
			{   

				quchu.Add (ii);


			}

		}


		int wwww=UnityEngine.Random.Range (0, quchu.Count);



		zuixiao = quchu [wwww];

		//print (zuixiao);

		f0 = zuixiao.ToString ();


		fs.Close ();
		sr.Close ();
		sr.Dispose ();  

	}



	void yandongshichang()
	{  




		FileStream recordingFile = new FileStream(@"" + pathh, FileMode.OpenOrCreate);
		StreamWriter sw = new StreamWriter(recordingFile);
		sw.Write(Environment.NewLine);
		sw.BaseStream.Seek(0, SeekOrigin.End);
		sw.Write(cishushu + "眼动时长 ");
		sw.Write (dx0 .ToString() + " ");
		sw.Write (dx1 .ToString() + " ");
		sw.Write (dx2 .ToString() + " ");
		sw.Write (dx3 .ToString() + " ");
		sw.Write (dx4 .ToString() + " ");
		sw.Write (dx5 .ToString() + " ");
		sw.Write (dx6 .ToString() + " ");
		sw.Write (dx7 .ToString() + " ");
		sw.Flush();
		sw.Close();




	}




}





