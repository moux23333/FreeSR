namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetPlayerBoardDataScRsp
	{
		[ProtoMember(11)] public int Retcode;
		[ProtoMember(8)] public List<KNIJOAHCPJO> UnlockedHeadIconList;
		[ProtoMember(14)] public MCHEJIHGFCE DisplayAvatarVec;
		[ProtoMember(15)] public string Signature;
		[ProtoMember(12)] public int CurrentHeadIconId;
		[ProtoMember(4)] public int GHEJADAMLJN;
	}
	
}
