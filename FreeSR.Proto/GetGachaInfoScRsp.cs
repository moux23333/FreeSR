namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetGachaInfoScRsp
	{
		[ProtoMember(7)] public int MHLGCEGDPPP;
		[ProtoMember(15)] public List<GachaInfo> GachaInfoList;
		[ProtoMember(6)] public int CEHNPOHELMK;
		[ProtoMember(8)] public int GachaRandom;
		[ProtoMember(9)] public int APNHGNGIKJM;
		[ProtoMember(11)] public int Retcode;
	}
	
}
