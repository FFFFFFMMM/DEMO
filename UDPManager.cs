
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class UDPManager : MonoBehaviour
{
	
	public static UDPManager instance;

	public AudioSource au;

	public GameObject TrancePlayer;
	public GameObject musicA;
	public GameObject musicB;
	public GameObject musicC;
	public GameObject musicD;
	public GameObject musicE;
	public GameObject musicF;
	public GameObject musicG;
	public GameObject musicH;
	public GameObject musicI;
	public GameObject musicJ;
	public GameObject musicK;
	public GameObject musicL;
	public GameObject musicM;
	public GameObject musicN;
	public GameObject musicO;
	public GameObject musicP;
	public GameObject musicQ;
	public GameObject musicR;
	public GameObject musicS;
	public GameObject musicT;
	public GameObject musicU;
	public GameObject musicV;
	public GameObject musicW;
	public GameObject musicX;
	public GameObject musicY;
	public GameObject musicZ;
	public GameObject musicA1;

	public bool musicAA = false;
	public bool musicBB = false;
	public bool musicCC = false;
	public bool musicDD = false;
	public bool musicEE = false;
	public bool musicFF = false;
	public bool musicGG = false;
	public bool musicHH = false;
	public bool musicII = false;
	public bool musicJJ = false;
	public bool musicKK = false;
	public bool musicLL = false;
	public bool musicMM = false;
	public bool musicNN = false;
	public bool musicOO = false;
	public bool musicPP = false;
	public bool musicQQ = false;
	public bool musicRR = false;
	public bool musicSS = false;
	public bool musicTT = false;
	public bool musicUU = false;
	public bool musicVV = false;
	public bool musicWW = false;
	public bool musicXX = false;
	public bool musicYY = false;
	public bool musicZZ = false;
	public bool musicAA1 = false;
	//public Text text;

	class UDPData
	{
		private readonly UdpClient udpClient;
		public UdpClient UDPClient
		{
			get { return udpClient; }
		}
		private readonly IPEndPoint endPoint;
		public IPEndPoint EndPoint
		{
			get { return endPoint; }
		}
		//构造函数
		public UDPData(IPEndPoint endPoint, UdpClient udpClient)
		{
			this.endPoint = endPoint;
			this.udpClient = udpClient;
		}
	}
	string receiveData = string.Empty;
	private Action<string> ReceiveCallBack = null;
	private Thread RecviveThread;
	private void Start()
	{
		//开启线程
		ThreadRecvive();
	
	}

	
	private void Update()
	{
		//text.text = receiveData;
		if (musicAA == false && musicBB == false && musicCC == false && musicDD == false && musicEE == false && musicFF == false && musicGG == false && musicHH == false&&musicII==false&&musicJJ==false && musicKK == false && musicLL == false && musicMM == false && musicNN == false && musicOO == false && musicPP == false && musicQQ == false && musicRR == false && musicSS == false && musicTT == false && musicUU == false && musicVV == false && musicWW == false && musicXX == false && musicYY == false && musicZZ == false && musicAA1 == false)
		{
		
			musicA.SetActive(false);
			musicB.SetActive(false);
			musicC.SetActive(false);
			musicD.SetActive(false);
			musicE.SetActive(false);
			musicF.SetActive(false);
			musicG.SetActive(false);
			musicH.SetActive(false);
			musicI.SetActive(false);
			au.enabled = false;


			TrancePlayer.GetComponent<TraceScenePlayer>().AA = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().BB = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().CC = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().DD = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().EE = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().FF = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().GG = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().HH = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().II = false;
			musicJ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().JJ = false;
			musicK.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().KK = false;
			musicL.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().LL = false;
			musicM.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().MM = false;
			musicN.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().NN = false;
			musicO.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().OO = false;
			musicP.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().PP = false;
			musicQ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().QQ = false;
			musicR.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().RR = false;
			musicS.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().SS = false;
			musicT.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().TT = false;
			musicU.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().UU = false;
			musicV.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().VV = false;
			musicW.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().WW = false;
			musicX.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().XX = false;
			musicY.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().YY = false;
			musicZ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().ZZ = false;
			musicA1.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().AAA = false;

		}

		if (musicAA == true)
		{
			au.enabled = true;
			musicA.SetActive(true);
			musicB.SetActive(false);
			musicC.SetActive(false);
			musicD.SetActive(false);
			musicE.SetActive(false);
			musicF.SetActive(false);
			musicG.SetActive(false);
			musicH.SetActive(false);
			musicI.SetActive(false);

			TrancePlayer.GetComponent<TraceScenePlayer>().AA = true;
			TrancePlayer.GetComponent<TraceScenePlayer>().BB = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().CC = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().DD = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().EE = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().FF = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().GG = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().HH = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().II = false;
			musicJ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().JJ = false;
			musicK.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().KK = false;
			musicL.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().LL = false;
			musicM.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().MM = false;
			musicN.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().NN = false;
			musicO.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().OO = false;
			musicP.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().PP = false;
			musicQ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().QQ = false;
			musicR.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().RR = false;
			musicS.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().SS = false;
			musicT.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().TT = false;
			musicU.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().UU = false;
			musicV.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().VV = false;
			musicW.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().WW = false;
			musicX.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().XX = false;
			musicY.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().YY = false;
			musicZ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().ZZ = false;
			musicA1.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().AAA = false;
		}
		if (musicBB == true)
		{
			au.enabled = true;
			musicA.SetActive(false);
			musicB.SetActive(true);
			musicC.SetActive(false);
			musicD.SetActive(false);
			musicE.SetActive(false);
			musicF.SetActive(false);
			musicG.SetActive(false);
			musicH.SetActive(false);
			musicI.SetActive(false);

			TrancePlayer.GetComponent<TraceScenePlayer>().AA = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().BB = true;
			TrancePlayer.GetComponent<TraceScenePlayer>().CC = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().DD = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().EE = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().FF = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().GG = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().HH = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().II = false;
			musicJ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().JJ = false;
			musicK.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().KK = false;
			musicL.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().LL = false;
			musicM.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().MM = false;
			musicN.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().NN = false;
			musicO.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().OO = false;
			musicP.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().PP = false;
			musicQ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().QQ = false;
			musicR.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().RR = false;
			musicS.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().SS = false;
			musicT.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().TT = false;
			musicU.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().UU = false;
			musicV.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().VV = false;
			musicW.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().WW = false;
			musicX.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().XX = false;
			musicY.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().YY = false;
			musicZ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().ZZ = false;
			musicA1.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().AAA = false;
		}
		if (musicCC == true)
		{
			au.enabled = true;
			musicA.SetActive(false);
			musicB.SetActive(false);
			musicC.SetActive(true);
			musicD.SetActive(false);
			musicE.SetActive(false);
			musicF.SetActive(false);
			musicG.SetActive(false);
			musicH.SetActive(false);
			musicI.SetActive(false);

			TrancePlayer.GetComponent<TraceScenePlayer>().AA = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().BB = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().CC = true;
			TrancePlayer.GetComponent<TraceScenePlayer>().DD = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().EE = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().FF = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().GG = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().HH = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().II = false;

			musicJ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().JJ = false;
			musicK.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().KK = false;
			musicL.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().LL = false;
			musicM.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().MM = false;
			musicN.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().NN = false;
			musicO.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().OO = false;
			musicP.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().PP = false;
			musicQ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().QQ = false;
			musicR.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().RR = false;
			musicS.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().SS = false;
			musicT.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().TT = false;
			musicU.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().UU = false;
			musicV.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().VV = false;
			musicW.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().WW = false;
			musicX.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().XX = false;
			musicY.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().YY = false;
			musicZ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().ZZ = false;
			musicA1.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().AAA = false;
		}
		if (musicDD == true)
		{
			au.enabled = true;
			musicA.SetActive(false);
			musicB.SetActive(false);
			musicC.SetActive(false);
			musicD.SetActive(true);
			musicE.SetActive(false);
			musicF.SetActive(false);
			musicG.SetActive(false);
			musicH.SetActive(false);
			musicI.SetActive(false);

			TrancePlayer.GetComponent<TraceScenePlayer>().AA = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().BB = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().CC = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().DD = true;
			TrancePlayer.GetComponent<TraceScenePlayer>().EE = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().FF = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().GG = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().HH = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().II = false;

			musicJ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().JJ = false;
			musicK.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().KK = false;
			musicL.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().LL = false;
			musicM.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().MM = false;
			musicN.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().NN = false;
			musicO.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().OO = false;
			musicP.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().PP = false;
			musicQ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().QQ = false;
			musicR.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().RR = false;
			musicS.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().SS = false;
			musicT.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().TT = false;
			musicU.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().UU = false;
			musicV.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().VV = false;
			musicW.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().WW = false;
			musicX.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().XX = false;
			musicY.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().YY = false;
			musicZ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().ZZ = false;
			musicA1.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().AAA = false;
		}
		if (musicEE == true)
		{
			au.enabled = true;
			musicA.SetActive(false);
			musicB.SetActive(false);
			musicC.SetActive(false);
			musicD.SetActive(false);
			musicE.SetActive(true);
			musicF.SetActive(false);
			musicG.SetActive(false);
			musicH.SetActive(false);
			musicI.SetActive(false);

			TrancePlayer.GetComponent<TraceScenePlayer>().AA = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().BB = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().CC = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().DD = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().EE = true;
			TrancePlayer.GetComponent<TraceScenePlayer>().FF = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().GG = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().HH = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().II = false;
			musicJ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().JJ = false;
			musicK.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().KK = false;
			musicL.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().LL = false;
			musicM.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().MM = false;
			musicN.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().NN = false;
			musicO.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().OO = false;
			musicP.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().PP = false;
			musicQ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().QQ = false;
			musicR.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().RR = false;
			musicS.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().SS = false;
			musicT.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().TT = false;
			musicU.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().UU = false;
			musicV.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().VV = false;
			musicW.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().WW = false;
			musicX.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().XX = false;
			musicY.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().YY = false;
			musicZ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().ZZ = false;
			musicA1.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().AAA = false;
		}
		if (musicFF == true)
		{
			au.enabled = true;
			musicA.SetActive(false);
			musicB.SetActive(false);
			musicC.SetActive(false);
			musicD.SetActive(false);
			musicE.SetActive(false);
			musicF.SetActive(true);
			musicG.SetActive(false);
			musicH.SetActive(false);
			musicI.SetActive(false);

			TrancePlayer.GetComponent<TraceScenePlayer>().AA = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().BB = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().CC = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().DD = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().EE = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().FF = true;
			TrancePlayer.GetComponent<TraceScenePlayer>().GG = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().HH = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().II = false;


			musicJ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().JJ = false;
			musicK.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().KK = false;
			musicL.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().LL = false;
			musicM.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().MM = false;
			musicN.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().NN = false;
			musicO.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().OO = false;
			musicP.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().PP = false;
			musicQ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().QQ = false;
			musicR.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().RR = false;
			musicS.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().SS = false;
			musicT.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().TT = false;
			musicU.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().UU = false;

			musicV.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().VV = false;
			musicW.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().WW = false;
			musicX.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().XX = false;
			musicY.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().YY = false;
			musicZ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().ZZ = false;
			musicA1.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().AAA = false;
		}
		if (musicGG == true)
		{
			au.enabled = true;
			musicA.SetActive(false);
			musicB.SetActive(false);
			musicC.SetActive(false);
			musicD.SetActive(false);
			musicE.SetActive(false);
			musicF.SetActive(false);
			musicG.SetActive(true);
			musicH.SetActive(false);
			musicI.SetActive(false);

			TrancePlayer.GetComponent<TraceScenePlayer>().AA = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().BB = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().CC = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().DD = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().EE = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().FF = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().GG = true;
			TrancePlayer.GetComponent<TraceScenePlayer>().HH = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().II = false;
			musicJ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().JJ = false;
			musicK.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().KK = false;
			musicL.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().LL = false;
			musicM.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().MM = false;
			musicN.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().NN = false;
			musicO.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().OO = false;
			musicP.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().PP = false;
			musicQ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().QQ = false;
			musicR.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().RR = false;
			musicS.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().SS = false;
			musicT.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().TT = false;
			musicU.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().UU = false;
			musicV.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().VV = false;
			musicW.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().WW = false;
			musicX.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().XX = false;
			musicY.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().YY = false;
			musicZ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().ZZ = false;
			musicA1.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().AAA = false;
		}

		if (musicHH == true)
		{
			au.enabled = true;
			musicA.SetActive(false);
			musicB.SetActive(false);
			musicC.SetActive(false);
			musicD.SetActive(false);
			musicE.SetActive(false);
			musicF.SetActive(false);
			musicG.SetActive(false);
			musicH.SetActive(true);
			musicI.SetActive(false);

			TrancePlayer.GetComponent<TraceScenePlayer>().AA = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().BB = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().CC = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().DD = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().EE = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().FF = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().GG = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().HH = true;
			TrancePlayer.GetComponent<TraceScenePlayer>().II = false;
			musicJ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().JJ = false;
			musicK.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().KK = false;
			musicL.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().LL = false;
			musicM.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().MM = false;
			musicN.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().NN = false;
			musicO.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().OO = false;
			musicP.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().PP = false;
			musicQ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().QQ = false;
			musicR.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().RR = false;
			musicS.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().SS = false;
			musicT.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().TT = false;
			musicU.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().UU = false;
			musicV.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().VV = false;
			musicW.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().WW = false;
			musicX.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().XX = false;
			musicY.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().YY = false;
			musicZ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().ZZ = false;
			musicA1.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().AAA = false;
		}
		if (musicII == true)
		{
			au.enabled = true;
			musicA.SetActive(false);
			musicB.SetActive(false);
			musicC.SetActive(false);
			musicD.SetActive(false);
			musicE.SetActive(false);
			musicF.SetActive(false);
			musicG.SetActive(false);
			musicH.SetActive(false);
			musicI.SetActive(true);

			TrancePlayer.GetComponent<TraceScenePlayer>().AA = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().BB = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().CC = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().DD = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().EE = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().FF = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().GG = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().HH = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().II = true;
			musicJ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().JJ = false;
			musicK.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().KK = false;
			musicL.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().LL = false;
			musicM.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().MM = false;
			musicN.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().NN = false;
			musicO.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().OO = false;
			musicP.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().PP = false;
			musicQ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().QQ = false;
			musicR.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().RR = false;
			musicS.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().SS = false;
			musicT.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().TT = false;
			musicU.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().UU = false;
			musicV.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().VV = false;
			musicW.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().WW = false;
			musicX.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().XX = false;
			musicY.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().YY = false;
			musicZ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().ZZ = false;
			musicA1.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().AAA = false;
		}
		if (musicJJ == true)
		{
			au.enabled = true;
			musicA.SetActive(false);
			musicB.SetActive(false);
			musicC.SetActive(false);
			musicD.SetActive(false);
			musicE.SetActive(false);
			musicF.SetActive(false);
			musicG.SetActive(false);
			musicH.SetActive(false);
			musicI.SetActive(false);

			TrancePlayer.GetComponent<TraceScenePlayer>().AA = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().BB = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().CC = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().DD = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().EE = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().FF = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().GG = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().HH = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().II = false;
			musicJ.SetActive(true);
			TrancePlayer.GetComponent<TraceScenePlayer>().JJ = true;
			musicK.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().KK = false;
			musicL.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().LL = false;
			musicM.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().MM = false;
			musicN.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().NN = false;
			musicO.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().OO = false;
			musicP.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().PP = false;
			musicQ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().QQ = false;
			musicR.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().RR = false;
			musicS.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().SS = false;
			musicT.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().TT = false;
			musicU.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().UU = false;
			musicV.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().VV = false;
			musicW.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().WW = false;
			musicX.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().XX = false;
			musicY.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().YY = false;
			musicZ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().ZZ = false;
			musicA1.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().AAA = false;
		}
		if (musicKK== true)
		{
			au.enabled = true;
			musicA.SetActive(false);
			musicB.SetActive(false);
			musicC.SetActive(false);
			musicD.SetActive(false);
			musicE.SetActive(false);
			musicF.SetActive(false);
			musicG.SetActive(false);
			musicH.SetActive(false);
			musicI.SetActive(false);

			TrancePlayer.GetComponent<TraceScenePlayer>().AA = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().BB = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().CC = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().DD = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().EE = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().FF = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().GG = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().HH = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().II = false;
			musicJ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().JJ = false;
			musicK.SetActive(true);
			TrancePlayer.GetComponent<TraceScenePlayer>().KK = true;
			musicL.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().LL = false;
			musicM.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().MM = false;
			musicN.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().NN = false;
			musicO.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().OO = false;
			musicP.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().PP = false;
			musicQ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().QQ = false;
			musicR.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().RR = false;
			musicS.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().SS = false;
			musicT.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().TT = false;
			musicU.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().UU = false;
			musicV.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().VV = false;
			musicW.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().WW = false;
			musicX.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().XX = false;
			musicY.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().YY = false;
			musicZ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().ZZ = false;
			musicA1.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().AAA = false;
		}
		if (musicLL == true)
		{
			au.enabled = true;
			musicA.SetActive(false);
			musicB.SetActive(false);
			musicC.SetActive(false);
			musicD.SetActive(false);
			musicE.SetActive(false);
			musicF.SetActive(false);
			musicG.SetActive(false);
			musicH.SetActive(false);
			musicI.SetActive(false);

			TrancePlayer.GetComponent<TraceScenePlayer>().AA = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().BB = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().CC = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().DD = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().EE = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().FF = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().GG = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().HH = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().II = false;
			musicJ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().JJ = false;
			musicK.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().KK = false;
			musicL.SetActive(true);
			TrancePlayer.GetComponent<TraceScenePlayer>().LL = true;
			musicM.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().MM = false;
			musicN.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().NN = false;
			musicO.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().OO = false;
			musicP.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().PP = false;
			musicQ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().QQ = false;
			musicR.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().RR = false;
			musicS.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().SS = false;
			musicT.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().TT = false;
			musicU.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().UU = false;
			musicV.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().VV = false;
			musicW.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().WW = false;
			musicX.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().XX = false;
			musicY.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().YY = false;
			musicZ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().ZZ = false;
			musicA1.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().AAA = false;
		}
		if (musicMM == true)
		{
			au.enabled = true;
			musicA.SetActive(false);
			musicB.SetActive(false);
			musicC.SetActive(false);
			musicD.SetActive(false);
			musicE.SetActive(false);
			musicF.SetActive(false);
			musicG.SetActive(false);
			musicH.SetActive(false);
			musicI.SetActive(false);

			TrancePlayer.GetComponent<TraceScenePlayer>().AA = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().BB = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().CC = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().DD = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().EE = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().FF = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().GG = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().HH = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().II = false;
			musicJ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().JJ = false;
			musicK.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().KK = false;
			musicL.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().LL = false;
			musicM.SetActive(true);
			TrancePlayer.GetComponent<TraceScenePlayer>().MM = true;
			musicN.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().NN = false;
			musicO.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().OO = false;
			musicP.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().PP = false;
			musicQ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().QQ = false;
			musicR.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().RR = false;
			musicS.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().SS = false;
			musicT.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().TT = false;
			musicU.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().UU = false;
			musicV.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().VV = false;
			musicW.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().WW = false;
			musicX.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().XX = false;
			musicY.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().YY = false;
			musicZ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().ZZ = false;
			musicA1.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().AAA = false;
		}
		if (musicNN == true)
		{
			au.enabled = true;
			musicA.SetActive(false);
			musicB.SetActive(false);
			musicC.SetActive(false);
			musicD.SetActive(false);
			musicE.SetActive(false);
			musicF.SetActive(false);
			musicG.SetActive(false);
			musicH.SetActive(false);
			musicI.SetActive(false);

			TrancePlayer.GetComponent<TraceScenePlayer>().AA = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().BB = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().CC = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().DD = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().EE = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().FF = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().GG = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().HH = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().II = false;
			musicJ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().JJ = false;
			musicK.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().KK = false;
			musicL.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().LL = false;
			musicM.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().MM = false;
			musicN.SetActive(true);
			TrancePlayer.GetComponent<TraceScenePlayer>().NN = true;
			musicO.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().OO = false;
			musicP.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().PP = false;
			musicQ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().QQ = false;
			musicR.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().RR = false;
			musicS.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().SS = false;
			musicT.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().TT = false;
			musicU.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().UU = false;
			musicV.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().VV = false;
			musicW.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().WW = false;
			musicX.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().XX = false;
			musicY.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().YY = false;
			musicZ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().ZZ = false;
			musicA1.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().AAA = false;
		}
		if (musicOO == true)
		{
			au.enabled = true;
			musicA.SetActive(false);
			musicB.SetActive(false);
			musicC.SetActive(false);
			musicD.SetActive(false);
			musicE.SetActive(false);
			musicF.SetActive(false);
			musicG.SetActive(false);
			musicH.SetActive(false);
			musicI.SetActive(false);

			TrancePlayer.GetComponent<TraceScenePlayer>().AA = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().BB = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().CC = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().DD = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().EE = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().FF = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().GG = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().HH = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().II = false;
			musicJ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().JJ = false;
			musicK.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().KK = false;
			musicL.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().LL = false;
			musicM.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().MM = false;
			musicN.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().NN = false;
			musicO.SetActive(true);
			TrancePlayer.GetComponent<TraceScenePlayer>().OO = true;
			musicP.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().PP = false;
			musicQ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().QQ = false;
			musicR.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().RR = false;
			musicS.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().SS = false;
			musicT.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().TT = false;
			musicU.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().UU = false;
			musicV.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().VV = false;
			musicW.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().WW = false;
			musicX.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().XX = false;
			musicY.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().YY = false;
			musicZ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().ZZ = false;
			musicA1.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().AAA = false;
		}
		if (musicPP == true)
		{
			au.enabled = true;
			musicA.SetActive(false);
			musicB.SetActive(false);
			musicC.SetActive(false);
			musicD.SetActive(false);
			musicE.SetActive(false);
			musicF.SetActive(false);
			musicG.SetActive(false);
			musicH.SetActive(false);
			musicI.SetActive(false);

			TrancePlayer.GetComponent<TraceScenePlayer>().AA = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().BB = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().CC = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().DD = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().EE = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().FF = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().GG = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().HH = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().II = false;
			musicJ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().JJ = false;
			musicK.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().KK = false;
			musicL.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().LL = false;
			musicM.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().MM = false;
			musicN.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().NN = false;
			musicO.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().OO = false;
			musicP.SetActive(true);
			TrancePlayer.GetComponent<TraceScenePlayer>().PP = true;
			musicQ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().QQ = false;
			musicR.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().RR = false;
			musicS.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().SS = false;
			musicT.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().TT = false;
			musicU.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().UU = false;
			musicV.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().VV = false;
			musicW.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().WW = false;
			musicX.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().XX = false;
			musicY.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().YY = false;
			musicZ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().ZZ = false;
			musicA1.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().AAA = false;
		}
		if (musicQQ == true)
		{
			au.enabled = true;
			musicA.SetActive(false);
			musicB.SetActive(false);
			musicC.SetActive(false);
			musicD.SetActive(false);
			musicE.SetActive(false);
			musicF.SetActive(false);
			musicG.SetActive(false);
			musicH.SetActive(false);
			musicI.SetActive(false);

			TrancePlayer.GetComponent<TraceScenePlayer>().AA = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().BB = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().CC = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().DD = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().EE = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().FF = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().GG = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().HH = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().II = false;
			musicJ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().JJ = false;
			musicK.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().KK = false;
			musicL.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().LL = false;
			musicM.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().MM = false;
			musicN.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().NN = false;
			musicO.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().OO = false;
			musicP.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().PP = false;
			musicQ.SetActive(true);
			TrancePlayer.GetComponent<TraceScenePlayer>().QQ = true;
			musicR.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().RR = false;
			musicS.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().SS = false;
			musicT.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().TT = false;
			musicU.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().UU = false;
			musicV.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().VV = false;
			musicW.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().WW = false;
			musicX.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().XX = false;
			musicY.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().YY = false;
			musicZ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().ZZ = false;
			musicA1.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().AAA = false;
		}
		if (musicRR == true)
		{
			au.enabled = true;
			musicA.SetActive(false);
			musicB.SetActive(false);
			musicC.SetActive(false);
			musicD.SetActive(false);
			musicE.SetActive(false);
			musicF.SetActive(false);
			musicG.SetActive(false);
			musicH.SetActive(false);
			musicI.SetActive(false);

			TrancePlayer.GetComponent<TraceScenePlayer>().AA = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().BB = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().CC = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().DD = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().EE = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().FF = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().GG = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().HH = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().II = false;
			musicJ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().JJ = false;
			musicK.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().KK = false;
			musicL.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().LL = false;
			musicM.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().MM = false;
			musicN.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().NN = false;
			musicO.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().OO = false;
			musicP.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().PP = false;
			musicQ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().QQ = false;
			musicR.SetActive(true);
			TrancePlayer.GetComponent<TraceScenePlayer>().RR = true;
			musicS.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().SS = false;
			musicT.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().TT = false;
			musicU.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().UU = false;
			musicV.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().VV = false;
			musicW.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().WW = false;
			musicX.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().XX = false;
			musicY.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().YY = false;
			musicZ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().ZZ = false;
			musicA1.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().AAA = false;
		}
		if (musicSS == true)
		{
			au.enabled = true;
			musicA.SetActive(false);
			musicB.SetActive(false);
			musicC.SetActive(false);
			musicD.SetActive(false);
			musicE.SetActive(false);
			musicF.SetActive(false);
			musicG.SetActive(false);
			musicH.SetActive(false);
			musicI.SetActive(false);

			TrancePlayer.GetComponent<TraceScenePlayer>().AA = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().BB = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().CC = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().DD = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().EE = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().FF = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().GG = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().HH = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().II = false;
			musicJ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().JJ = false;
			musicK.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().KK = false;
			musicL.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().LL = false;
			musicM.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().MM = false;
			musicN.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().NN = false;
			musicO.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().OO = false;
			musicP.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().PP = false;
			musicQ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().QQ = false;
			musicR.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().RR = false;
			musicS.SetActive(true);
			TrancePlayer.GetComponent<TraceScenePlayer>().SS = true;
			musicT.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().TT = false;
			musicU.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().UU = false;
			musicV.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().VV = false;
			musicW.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().WW = false;
			musicX.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().XX = false;
			musicY.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().YY = false;
			musicZ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().ZZ = false;
			musicA1.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().AAA = false;
		}
		if (musicTT == true)
		{
			au.enabled = true;
			musicA.SetActive(false);
			musicB.SetActive(false);
			musicC.SetActive(false);
			musicD.SetActive(false);
			musicE.SetActive(false);
			musicF.SetActive(false);
			musicG.SetActive(false);
			musicH.SetActive(false);
			musicI.SetActive(false);

			TrancePlayer.GetComponent<TraceScenePlayer>().AA = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().BB = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().CC = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().DD = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().EE = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().FF = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().GG = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().HH = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().II = false;
			musicJ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().JJ = false;
			musicK.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().KK = false;
			musicL.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().LL = false;
			musicM.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().MM = false;
			musicN.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().NN = false;
			musicO.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().OO = false;
			musicP.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().PP = false;
			musicQ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().QQ = false;
			musicR.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().RR = false;
			musicS.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().SS = false;
			musicT.SetActive(true);
			TrancePlayer.GetComponent<TraceScenePlayer>().TT = true;
			musicU.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().UU = false;
			musicV.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().VV = false;
			musicW.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().WW = false;
			musicX.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().XX = false;
			musicY.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().YY = false;
			musicZ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().ZZ = false;
			musicA1.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().AAA = false;
		}
		if (musicUU == true)
		{
			au.enabled = true;
			musicA.SetActive(false);
			musicB.SetActive(false);
			musicC.SetActive(false);
			musicD.SetActive(false);
			musicE.SetActive(false);
			musicF.SetActive(false);
			musicG.SetActive(false);
			musicH.SetActive(false);
			musicI.SetActive(false);

			TrancePlayer.GetComponent<TraceScenePlayer>().AA = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().BB = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().CC = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().DD = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().EE = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().FF = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().GG = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().HH = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().II = false;
			musicJ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().JJ = false;
			musicK.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().KK = false;
			musicL.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().LL = false;
			musicM.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().MM = false;
			musicN.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().NN = false;
			musicO.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().OO = false;
			musicP.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().PP = false;
			musicQ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().QQ = false;
			musicR.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().RR = false;
			musicS.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().SS = false;
			musicT.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().TT = false;
			musicU.SetActive(true);
			TrancePlayer.GetComponent<TraceScenePlayer>().UU = true;
			musicV.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().VV = false;
			musicW.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().WW = false;
			musicX.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().XX = false;
			musicY.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().YY = false;
			musicZ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().ZZ = false;
			musicA1.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().AAA = false;
		}
		if (musicVV == true)
		{
			au.enabled = true;
			musicA.SetActive(false);
			musicB.SetActive(false);
			musicC.SetActive(false);
			musicD.SetActive(false);
			musicE.SetActive(false);
			musicF.SetActive(false);
			musicG.SetActive(false);
			musicH.SetActive(false);
			musicI.SetActive(false);

			TrancePlayer.GetComponent<TraceScenePlayer>().AA = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().BB = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().CC = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().DD = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().EE = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().FF = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().GG = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().HH = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().II = false;
			musicJ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().JJ = false;
			musicK.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().KK = false;
			musicL.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().LL = false;
			musicM.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().MM = false;
			musicN.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().NN = false;
			musicO.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().OO = false;
			musicP.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().PP = false;
			musicQ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().QQ = false;
			musicR.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().RR = false;
			musicS.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().SS = false;
			musicT.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().TT = false;
			musicU.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().UU = false;
			musicV.SetActive(true);
			TrancePlayer.GetComponent<TraceScenePlayer>().VV = true;
			musicW.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().WW = false;
			musicX.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().XX = false;
			musicY.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().YY = false;
			musicZ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().ZZ = false;
			musicA1.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().AAA = false;
		}
		if (musicWW == true)
		{
			au.enabled = true;
			musicA.SetActive(false);
			musicB.SetActive(false);
			musicC.SetActive(false);
			musicD.SetActive(false);
			musicE.SetActive(false);
			musicF.SetActive(false);
			musicG.SetActive(false);
			musicH.SetActive(false);
			musicI.SetActive(false);

			TrancePlayer.GetComponent<TraceScenePlayer>().AA = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().BB = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().CC = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().DD = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().EE = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().FF = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().GG = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().HH = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().II = false;
			musicJ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().JJ = false;
			musicK.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().KK = false;
			musicL.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().LL = false;
			musicM.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().MM = false;
			musicN.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().NN = false;
			musicO.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().OO = false;
			musicP.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().PP = false;
			musicQ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().QQ = false;
			musicR.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().RR = false;
			musicS.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().SS = false;
			musicT.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().TT = false;
			musicU.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().UU = false;
			musicV.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().VV = false;
			musicW.SetActive(true);
			TrancePlayer.GetComponent<TraceScenePlayer>().WW = true;
			musicX.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().XX = false;
			musicY.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().YY = false;
			musicZ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().ZZ = false;
			musicA1.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().AAA = false;
		}
		if (musicXX == true)
		{
			au.enabled = true;
			musicA.SetActive(false);
			musicB.SetActive(false);
			musicC.SetActive(false);
			musicD.SetActive(false);
			musicE.SetActive(false);
			musicF.SetActive(false);
			musicG.SetActive(false);
			musicH.SetActive(false);
			musicI.SetActive(false);

			TrancePlayer.GetComponent<TraceScenePlayer>().AA = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().BB = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().CC = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().DD = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().EE = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().FF = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().GG = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().HH = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().II = false;
			musicJ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().JJ = false;
			musicK.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().KK = false;
			musicL.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().LL = false;
			musicM.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().MM = false;
			musicN.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().NN = false;
			musicO.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().OO = false;
			musicP.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().PP = false;
			musicQ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().QQ = false;
			musicR.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().RR = false;
			musicS.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().SS = false;
			musicT.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().TT = false;
			musicU.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().UU = false;
			musicV.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().VV = false;
			musicW.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().WW = false;
			musicX.SetActive(true);
			TrancePlayer.GetComponent<TraceScenePlayer>().XX = true;
			musicY.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().YY = false;
			musicZ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().ZZ = false;
			musicA1.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().AAA = false;
		}
		if (musicYY == true)
		{
			au.enabled = true;
			musicA.SetActive(false);
			musicB.SetActive(false);
			musicC.SetActive(false);
			musicD.SetActive(false);
			musicE.SetActive(false);
			musicF.SetActive(false);
			musicG.SetActive(false);
			musicH.SetActive(false);
			musicI.SetActive(false);

			TrancePlayer.GetComponent<TraceScenePlayer>().AA = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().BB = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().CC = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().DD = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().EE = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().FF = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().GG = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().HH = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().II = false;
			musicJ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().JJ = false;
			musicK.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().KK = false;
			musicL.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().LL = false;
			musicM.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().MM = false;
			musicN.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().NN = false;
			musicO.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().OO = false;
			musicP.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().PP = false;
			musicQ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().QQ = false;
			musicR.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().RR = false;
			musicS.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().SS = false;
			musicT.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().TT = false;
			musicU.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().UU = false;
			musicV.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().VV = false;
			musicW.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().WW = false;
			musicX.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().XX = false;
			musicY.SetActive(true);
			TrancePlayer.GetComponent<TraceScenePlayer>().YY = true;
			musicZ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().ZZ = false;
			musicA1.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().AAA = false;
		}
		if (musicZZ == true)
		{
			au.enabled = true;
			musicA.SetActive(false);
			musicB.SetActive(false);
			musicC.SetActive(false);
			musicD.SetActive(false);
			musicE.SetActive(false);
			musicF.SetActive(false);
			musicG.SetActive(false);
			musicH.SetActive(false);
			musicI.SetActive(false);

			TrancePlayer.GetComponent<TraceScenePlayer>().AA = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().BB = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().CC = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().DD = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().EE = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().FF = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().GG = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().HH = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().II = false;
			musicJ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().JJ = false;
			musicK.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().KK = false;
			musicL.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().LL = false;
			musicM.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().MM = false;
			musicN.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().NN = false;
			musicO.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().OO = false;
			musicP.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().PP = false;
			musicQ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().QQ = false;
			musicR.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().RR = false;
			musicS.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().SS = false;
			musicT.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().TT = false;
			musicU.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().UU = false;
			musicV.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().VV = false;
			musicW.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().WW = false;
			musicX.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().XX = false;
			musicY.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().YY = false;
			musicZ.SetActive(true);
			TrancePlayer.GetComponent<TraceScenePlayer>().ZZ = true;
			musicA1.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().AAA = false;
		}
		if (musicAA1 == true)
		{
			au.enabled = true;
			musicA.SetActive(false);
			musicB.SetActive(false);
			musicC.SetActive(false);
			musicD.SetActive(false);
			musicE.SetActive(false);
			musicF.SetActive(false);
			musicG.SetActive(false);
			musicH.SetActive(false);
			musicI.SetActive(false);

			TrancePlayer.GetComponent<TraceScenePlayer>().AA = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().BB = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().CC = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().DD = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().EE = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().FF = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().GG = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().HH = false;
			TrancePlayer.GetComponent<TraceScenePlayer>().II = false;
			musicJ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().JJ = false;
			musicK.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().KK = false;
			musicL.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().LL = false;
			musicM.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().MM = false;
			musicN.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().NN = false;
			musicO.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().OO = false;
			musicP.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().PP = false;
			musicQ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().QQ = false;
			musicR.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().RR = false;
			musicS.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().SS = false;
			musicT.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().TT = false;
			musicU.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().UU = false;
			musicV.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().VV = false;
			musicW.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().WW = false;
			musicX.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().XX = false;
			musicY.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().YY = false;
			musicZ.SetActive(false);
			TrancePlayer.GetComponent<TraceScenePlayer>().ZZ = false;
			musicA1.SetActive(true);
			TrancePlayer.GetComponent<TraceScenePlayer>().AAA = true;
		}
		if (ReceiveCallBack != null &&
			!string.IsNullOrEmpty(receiveData))
		{
			//调用处理函数去数据进行处理
			ReceiveCallBack(receiveData);
			//使用之后清空接受的数据
			receiveData = string.Empty;
		}
	}
	private void OnDestroy()
	{
		if (RecviveThread != null)
		{
			RecviveThread.Abort();
		}
	}
	public void SetReceiveCallBack(Action<string> action)
	{
		ReceiveCallBack = action;
	}
	/// <summary>
	/// 开始线程接收
	/// </summary>
	private void ThreadRecvive()
	{
		//开一个新线程接收UDP发送的数据
		RecviveThread = new Thread(() =>
		{
			//实例化一个IPEndPoint，任意IP和对应端口 端口自行修改
			IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 7878);
			UdpClient udpReceive = new UdpClient(endPoint);
			UDPData data = new UDPData(endPoint, udpReceive);
			//开启异步接收
			udpReceive.BeginReceive(CallBackRecvive, data);
		})
		{
			//设置为后台线程
			IsBackground = true
		};
		//开启线程
		RecviveThread.Start();
	}

	/// <summary>
	/// 异步接收回调
	/// </summary>
	/// <param name="ar"></param>
	private void CallBackRecvive(IAsyncResult ar)
	{
		try
		{
			//将传过来的异步结果转为我们需要解析的类型
			UDPData state = ar.AsyncState as UDPData;
			IPEndPoint ipEndPoint = state.EndPoint;
			//结束异步接受 不结束会导致重复挂起线程卡死
			byte[] data = state.UDPClient.EndReceive(ar, ref ipEndPoint);
			//解析数据 编码自己调整暂定为默认 依客户端传过来的编码而定
			string receiveData = Encoding.Default.GetString(data);
			string recvStr = receiveData;
			if (int.Parse(recvStr) != 10020 || int.Parse(recvStr) != 10021 || int.Parse(recvStr) != 10022 || int.Parse(recvStr) != 10023 || int.Parse(recvStr) != 10024 || int.Parse(recvStr) != 10025 || int.Parse(recvStr) != 10026 || int.Parse(recvStr) != 10027 || int.Parse(recvStr) != 10028 || int.Parse(recvStr) != 10029 || int.Parse(recvStr) != 10030 || int.Parse(recvStr) != 10031 || int.Parse(recvStr) != 10032 || int.Parse(recvStr) != 10033 || int.Parse(recvStr) != 10034 || int.Parse(recvStr) != 10035 || int.Parse(recvStr) != 10036 || int.Parse(recvStr) != 10037 || int.Parse(recvStr) != 10038 || int.Parse(recvStr) != 10039 || int.Parse(recvStr) != 10040 || int.Parse(recvStr) != 10041 || int.Parse(recvStr) != 10042 || int.Parse(recvStr) != 10043 || int.Parse(recvStr) != 10044 || int.Parse(recvStr) != 10045 || int.Parse(recvStr) != 10046)
			{

				musicAA = false;
				musicBB = false;
				musicCC = false;
				musicDD = false;
				musicEE = false;
				musicFF = false;
				musicGG = false;
				musicHH = false;
				musicII = false;
				musicJJ = false;
				musicKK = false;
				musicLL = false;
				musicMM = false;
				musicNN = false;
				musicOO = false;
				musicPP = false;
				musicQQ = false;
				musicRR = false;
				musicSS = false;
				musicTT = false;
				musicUU = false;
				musicVV = false;
				musicWW = false;
				musicXX = false;
				musicYY = false;
				musicZZ = false;
				musicAA1 = false;
			}
			if (int.Parse(recvStr) == 10020)
			{
				musicAA = true;
				musicBB = false;
				musicCC = false;
				musicDD = false;
				musicEE = false;
				musicFF = false;
				musicGG = false;
				musicHH = false;
				musicII = false;
				musicJJ = false;
				musicKK = false;
				musicLL = false;
				musicMM = false;
				musicNN = false;
				musicOO = false;
				musicPP = false;
				musicQQ = false;
				musicRR = false;
				musicSS = false;
				musicTT = false;
				musicUU = false;
				musicVV = false;
				musicWW = false;
				musicXX = false;
				musicYY = false;
				musicZZ = false;
				musicAA1 = false;
			}
			if (int.Parse(recvStr) == 10021)
			{
				musicAA = false;
				musicBB = true;
				musicCC = false;
				musicDD = false;
				musicEE = false;
				musicFF = false;
				musicGG = false;
				musicHH = false;
				musicII = false;
				musicJJ = false;
				musicKK = false;
				musicLL = false;
				musicMM = false;
				musicNN = false;
				musicOO = false;
				musicPP = false;
				musicQQ = false;
				musicRR = false;
				musicSS = false;
				musicTT = false;
				musicUU = false;
				musicVV = false;
				musicWW = false;
				musicXX = false;
				musicYY = false;
				musicZZ = false;
				musicAA1 = false;
			}
			if (int.Parse(recvStr) == 10022)
			{
				musicAA = false;
				musicBB = false;
				musicCC = true;
				musicDD = false;
				musicEE = false;
				musicFF = false;
				musicGG = false;
				musicHH = false;
				musicII = false;
				musicJJ = false;
				musicKK = false;
				musicLL = false;
				musicMM = false;
				musicNN = false;
				musicOO = false;
				musicPP = false;
				musicQQ = false;
				musicRR = false;
				musicSS = false;
				musicTT = false;
				musicUU = false;
				musicVV = false;
				musicWW = false;
				musicXX = false;
				musicYY = false;
				musicZZ = false;
				musicAA1 = false;
			}
			if (int.Parse(recvStr) == 10023)
			{
				musicAA = false;
				musicBB = false;
				musicCC = false;
				musicDD = true;
				musicEE = false;
				musicFF = false;
				musicGG = false;
				musicHH = false;
				musicII = false;
				musicJJ = false;
				musicKK = false;
				musicLL = false;
				musicMM = false;
				musicNN = false;
				musicOO = false;
				musicPP = false;
				musicQQ = false;
				musicRR = false;
				musicSS = false;
				musicTT = false;
				musicUU = false;
				musicVV = false;
				musicWW = false;
				musicXX = false;
				musicYY = false;
				musicZZ = false;
				musicAA1 = false;
			}
			if (int.Parse(recvStr) == 10024)
			{
				musicAA = false;
				musicBB = false;
				musicCC = false;
				musicDD = false;
				musicEE = true;
				musicFF = false;
				musicGG = false;
				musicHH = false;
				musicII = false;
				musicJJ = false;
				musicKK = false;
				musicLL = false;
				musicMM = false;
				musicNN = false;
				musicOO = false;
				musicPP = false;
				musicQQ = false;
				musicRR = false;
				musicSS = false;
				musicTT = false;
				musicUU = false;
				musicVV = false;
				musicWW = false;
				musicXX = false;
				musicYY = false;
				musicZZ = false;
				musicAA1 = false;
			}
			if (int.Parse(recvStr) == 10025)
			{
				musicAA = false;
				musicBB = false;
				musicCC = false;
				musicDD = false;
				musicEE = false;
				musicFF = true;
				musicGG = false;
				musicHH = false;
				musicII = false;
				musicJJ = false;
				musicKK = false;
				musicLL = false;
				musicMM = false;
				musicNN = false;
				musicOO = false;
				musicPP = false;
				musicQQ = false;
				musicRR = false;
				musicSS = false;
				musicTT = false;
				musicUU = false;
				musicVV = false;
				musicWW = false;
				musicXX = false;
				musicYY = false;
				musicZZ = false;
				musicAA1 = false;
			}
			if (int.Parse(recvStr) == 10026)
			{
				musicAA = false;
				musicBB = false;
				musicCC = false;
				musicDD = false;
				musicEE = false;
				musicFF = false;
				musicGG = true;
				musicHH = false;
				musicII = false;
				musicJJ = false;
				musicKK = false;
				musicLL = false;
				musicMM = false;
				musicNN = false;
				musicOO = false;
				musicPP = false;
				musicQQ = false;
				musicRR = false;
				musicSS = false;
				musicTT = false;
				musicUU = false;
				musicVV = false;
				musicWW = false;
				musicXX = false;
				musicYY = false;
				musicZZ = false;
				musicAA1 = false;
			}
			if (int.Parse(recvStr) == 10027)
			{
				musicAA = false;
				musicBB = false;
				musicCC = false;
				musicDD = false;
				musicEE = false;
				musicFF = false;
				musicGG = false;
				musicHH = true;
				musicII = false;
				musicJJ = false;
				musicKK = false;
				musicLL = false;
				musicMM = false;
				musicNN = false;
				musicOO = false;
				musicPP = false;
				musicQQ = false;
				musicRR = false;
				musicSS = false;
				musicTT = false;
				musicUU = false;
				musicVV = false;
				musicWW = false;
				musicXX = false;
				musicYY = false;
				musicZZ = false;
				musicAA1 = false;
			}
			if (int.Parse(recvStr) == 10028)
			{
				musicAA = false;
				musicBB = false;
				musicCC = false;
				musicDD = false;
				musicEE = false;
				musicFF = false;
				musicGG = false;
				musicHH = false;
				musicII = true;
				musicJJ = false;
				musicKK = false;
				musicLL = false;
				musicMM = false;
				musicNN = false;
				musicOO = false;
				musicPP = false;
				musicQQ = false;
				musicRR = false;
				musicSS = false;
				musicTT = false;
				musicUU = false;
				musicVV = false;
				musicWW = false;
				musicXX = false;
				musicYY = false;
				musicZZ = false;
				musicAA1 = false;
			}
			if (int.Parse(recvStr) == 10029)
			{
				musicAA = false;
				musicBB = false;
				musicCC = false;
				musicDD = false;
				musicEE = false;
				musicFF = false;
				musicGG = false;
				musicHH = false;
				musicII = false;
				musicJJ = true;
				musicKK = false;
				musicLL = false;
				musicMM = false;
				musicNN = false;
				musicOO = false;
				musicPP = false;
				musicQQ = false;
				musicRR = false;
				musicSS = false;
				musicTT = false;
				musicUU = false;
				musicVV = false;
				musicWW = false;
				musicXX = false;
				musicYY = false;
				musicZZ = false;
				musicAA1 = false;
			}
			if (int.Parse(recvStr) == 10030)
			{
				musicAA = false;
				musicBB = false;
				musicCC = false;
				musicDD = false;
				musicEE = false;
				musicFF = false;
				musicGG = false;
				musicHH = false;
				musicII = false;
				musicJJ = false;
				musicKK = true;
				musicLL = false;
				musicMM = false;
				musicNN = false;
				musicOO = false;
				musicPP = false;
				musicQQ = false;
				musicRR = false;
				musicSS = false;
				musicTT = false;
				musicUU = false;
				musicVV = false;
				musicWW = false;
				musicXX = false;
				musicYY = false;
				musicZZ = false;
				musicAA1 = false;
			}
			if (int.Parse(recvStr) == 10031)
			{
				musicAA = false;
				musicBB = false;
				musicCC = false;
				musicDD = false;
				musicEE = false;
				musicFF = false;
				musicGG = false;
				musicHH = false;
				musicII = false;
				musicJJ = false;
				musicKK = false;
				musicLL = true;
				musicMM = false;
				musicNN = false;
				musicOO = false;
				musicPP = false;
				musicQQ = false;
				musicRR = false;
				musicSS = false;
				musicTT = false;
				musicUU = false;
				musicVV = false;
				musicWW = false;
				musicXX = false;
				musicYY = false;
				musicZZ = false;
				musicAA1 = false;
			}
			if (int.Parse(recvStr) == 10032)
			{
				musicAA = false;
				musicBB = false;
				musicCC = false;
				musicDD = false;
				musicEE = false;
				musicFF = false;
				musicGG = false;
				musicHH = false;
				musicII = false;
				musicJJ = false;
				musicKK = false;
				musicLL = false;
				musicMM = true;
				musicNN = false;
				musicOO = false;
				musicPP = false;
				musicQQ = false;
				musicRR = false;
				musicSS = false;
				musicTT = false;
				musicUU = false;
				musicVV = false;
				musicWW = false;
				musicXX = false;
				musicYY = false;
				musicZZ = false;
				musicAA1 = false;
			}
			if (int.Parse(recvStr) == 10033)
			{
				musicAA = false;
				musicBB = false;
				musicCC = false;
				musicDD = false;
				musicEE = false;
				musicFF = false;
				musicGG = false;
				musicHH = false;
				musicII = false;
				musicJJ = false;
				musicKK = false;
				musicLL = false;
				musicMM = false;
				musicNN = true;
				musicOO = false;
				musicPP = false;
				musicQQ = false;
				musicRR = false;
				musicSS = false;
				musicTT = false;
				musicUU = false;
				musicVV = false;
				musicWW = false;
				musicXX = false;
				musicYY = false;
				musicZZ = false;
				musicAA1 = false;
			}
			if (int.Parse(recvStr) == 10034)
			{
				musicAA = false;
				musicBB = false;
				musicCC = false;
				musicDD = false;
				musicEE = false;
				musicFF = false;
				musicGG = false;
				musicHH = false;
				musicII = false;
				musicJJ = false;
				musicKK = false;
				musicLL = false;
				musicMM = false;
				musicNN = false;
				musicOO = true;
				musicPP = false;
				musicQQ = false;
				musicRR = false;
				musicSS = false;
				musicTT = false;
				musicUU = false;
				musicVV = false;
				musicWW = false;
				musicXX = false;
				musicYY = false;
				musicZZ = false;
				musicAA1 = false;
			}
			if (int.Parse(recvStr) == 10035)
			{
				musicAA = false;
				musicBB = false;
				musicCC = false;
				musicDD = false;
				musicEE = false;
				musicFF = false;
				musicGG = false;
				musicHH = false;
				musicII = false;
				musicJJ = false;
				musicKK = false;
				musicLL = false;
				musicMM = false;
				musicNN = false;
				musicOO = false;
				musicPP = true;
				musicQQ = false;
				musicRR = false;
				musicSS = false;
				musicTT = false;
				musicUU = false;
				musicVV = false;
				musicWW = false;
				musicXX = false;
				musicYY = false;
				musicZZ = false;
				musicAA1 = false;
			}
			if (int.Parse(recvStr) == 10036)
			{
				musicAA = false;
				musicBB = false;
				musicCC = false;
				musicDD = false;
				musicEE = false;
				musicFF = false;
				musicGG = false;
				musicHH = false;
				musicII = false;
				musicJJ = false;
				musicKK = false;
				musicLL = false;
				musicMM = false;
				musicNN = false;
				musicOO = false;
				musicPP = false;
				musicQQ = true;
				musicRR = false;
				musicSS = false;
				musicTT = false;
				musicUU = false;
				musicVV = false;
				musicWW = false;
				musicXX = false;
				musicYY = false;
				musicZZ = false;
				musicAA1 = false;
			}
			if (int.Parse(recvStr) == 10037)
			{
				musicAA = false;
				musicBB = false;
				musicCC = false;
				musicDD = false;
				musicEE = false;
				musicFF = false;
				musicGG = false;
				musicHH = false;
				musicII = false;
				musicJJ = false;
				musicKK = false;
				musicLL = false;
				musicMM = false;
				musicNN = false;
				musicOO = false;
				musicPP = false;
				musicQQ = false;
				musicRR = true;
				musicSS = false;
				musicTT = false;
				musicUU = false;
				musicVV = false;
				musicWW = false;
				musicXX = false;
				musicYY = false;
				musicZZ = false;
				musicAA1 = false;
			}
			if (int.Parse(recvStr) == 10038)
			{
				musicAA = false;
				musicBB = false;
				musicCC = false;
				musicDD = false;
				musicEE = false;
				musicFF = false;
				musicGG = false;
				musicHH = false;
				musicII = false;
				musicJJ = false;
				musicKK = false;
				musicLL = false;
				musicMM = false;
				musicNN = false;
				musicOO = false;
				musicPP = false;
				musicQQ = false;
				musicRR = false;
				musicSS = true;
				musicTT = false;
				musicUU = false;
				musicVV = false;
				musicWW = false;
				musicXX = false;
				musicYY = false;
				musicZZ = false;
				musicAA1 = false;
			}
			if (int.Parse(recvStr) == 10039)
			{
				musicAA = false;
				musicBB = false;
				musicCC = false;
				musicDD = false;
				musicEE = false;
				musicFF = false;
				musicGG = false;
				musicHH = false;
				musicII = false;
				musicJJ = false;
				musicKK = false;
				musicLL = false;
				musicMM = false;
				musicNN = false;
				musicOO = false;
				musicPP = false;
				musicQQ = false;
				musicRR = false;
				musicSS = false;
				musicTT = true;
				musicUU = false;
				musicVV = false;
				musicWW = false;
				musicXX = false;
				musicYY = false;
				musicZZ = false;
				musicAA1 = false;
			}
			if (int.Parse(recvStr) == 10040)
			{
				musicAA = false;
				musicBB = false;
				musicCC = false;
				musicDD = false;
				musicEE = false;
				musicFF = false;
				musicGG = false;
				musicHH = false;
				musicII = false;
				musicJJ = false;
				musicKK = false;
				musicLL = false;
				musicMM = false;
				musicNN = false;
				musicOO = false;
				musicPP = false;
				musicQQ = false;
				musicRR = false;
				musicSS = false;
				musicTT = false;
				musicUU = true;
				musicVV = false;
				musicWW = false;
				musicXX = false;
				musicYY = false;
				musicZZ = false;
				musicAA1 = false;
			}
			if (int.Parse(recvStr) == 10041)
			{
				musicAA = false;
				musicBB = false;
				musicCC = false;
				musicDD = false;
				musicEE = false;
				musicFF = false;
				musicGG = false;
				musicHH = false;
				musicII = false;
				musicJJ = false;
				musicKK = false;
				musicLL = false;
				musicMM = false;
				musicNN = false;
				musicOO = false;
				musicPP = false;
				musicQQ = false;
				musicRR = false;
				musicSS = false;
				musicTT = false;
				musicUU = false;
				musicVV = true;
				musicWW = false;
				musicXX = false;
				musicYY = false;
				musicZZ = false;
				musicAA1 = false;
			}
			if (int.Parse(recvStr) == 10042)
			{
				musicAA = false;
				musicBB = false;
				musicCC = false;
				musicDD = false;
				musicEE = false;
				musicFF = false;
				musicGG = false;
				musicHH = false;
				musicII = false;
				musicJJ = false;
				musicKK = false;
				musicLL = false;
				musicMM = false;
				musicNN = false;
				musicOO = false;
				musicPP = false;
				musicQQ = false;
				musicRR = false;
				musicSS = false;
				musicTT = false;
				musicUU = false;
				musicVV = false;
				musicWW = true;
				musicXX = false;
				musicYY = false;
				musicZZ = false;
				musicAA1 = false;
			}
			if (int.Parse(recvStr) == 10043)
			{
				musicAA = false;
				musicBB = false;
				musicCC = false;
				musicDD = false;
				musicEE = false;
				musicFF = false;
				musicGG = false;
				musicHH = false;
				musicII = false;
				musicJJ = false;
				musicKK = false;
				musicLL = false;
				musicMM = false;
				musicNN = false;
				musicOO = false;
				musicPP = false;
				musicQQ = false;
				musicRR = false;
				musicSS = false;
				musicTT = false;
				musicUU = false;
				musicVV = false;
				musicWW = false;
				musicXX = true;
				musicYY = false;
				musicZZ = false;
				musicAA1 = false;
			}
			if (int.Parse(recvStr) == 10044)
			{
				musicAA = false;
				musicBB = false;
				musicCC = false;
				musicDD = false;
				musicEE = false;
				musicFF = false;
				musicGG = false;
				musicHH = false;
				musicII = false;
				musicJJ = false;
				musicKK = false;
				musicLL = false;
				musicMM = false;
				musicNN = false;
				musicOO = false;
				musicPP = false;
				musicQQ = false;
				musicRR = false;
				musicSS = false;
				musicTT = false;
				musicUU = false;
				musicVV = false;
				musicWW = false;
				musicXX = false;
				musicYY = true;
				musicZZ = false;
				musicAA1 = false;
			}
			if (int.Parse(recvStr) == 10045)
			{
				musicAA = false;
				musicBB = false;
				musicCC = false;
				musicDD = false;
				musicEE = false;
				musicFF = false;
				musicGG = false;
				musicHH = false;
				musicII = false;
				musicJJ = false;
				musicKK = false;
				musicLL = false;
				musicMM = false;
				musicNN = false;
				musicOO = false;
				musicPP = false;
				musicQQ = false;
				musicRR = false;
				musicSS = false;
				musicTT = false;
				musicUU = false;
				musicVV = false;
				musicWW = false;
				musicXX = false;
				musicYY = false;
				musicZZ = true;
				musicAA1 = false;
			}
			if (int.Parse(recvStr) == 10046)
			{
				musicAA = false;
				musicBB = false;
				musicCC = false;
				musicDD = false;
				musicEE = false;
				musicFF = false;
				musicGG = false;
				musicHH = false;
				musicII = false;
				musicJJ = false;
				musicKK = false;
				musicLL = false;
				musicMM = false;
				musicNN = false;
				musicOO = false;
				musicPP = false;
				musicQQ = false;
				musicRR = false;
				musicSS = false;
				musicTT = false;
				musicUU = false;
				musicVV = false;
				musicWW = false;
				musicXX = false;
				musicYY = false;
				musicZZ = false;
				musicAA1 = true;
			}
			Debug.Log(receiveData);
		


			//数据的解析再Update里执行 Unity中Thread无法调用主线程的方法
			//再次开启异步接收数据
			state.UDPClient.BeginReceive(CallBackRecvive, state);
		}
		catch (Exception e)
		{
			Debug.LogError(e.Message);
			throw;
		}
	}
	/// <summary>
	/// 发送UDP信息
	/// </summary>
	/// <param name="remoteIP">发送地址</param>
	/// <param name="remotePort">发送端口</param>
	/// <param name="message">需要发送的信息</param>
	public void UDPSendMessage(string remoteIP, int remotePort, string message)
	{
		//将需要发送的内容转为byte数组 编码依接收端为主，自行修改
		byte[] sendbytes = Encoding.Unicode.GetBytes(message);
		IPEndPoint remoteIPEndPoint = new IPEndPoint(IPAddress.Parse(remoteIP), remotePort);
		UdpClient udpSend = new UdpClient();
		//发送数据到对应目标
		udpSend.Send(sendbytes, sendbytes.Length, remoteIPEndPoint);
		//关闭
		udpSend.Close();
	}
}