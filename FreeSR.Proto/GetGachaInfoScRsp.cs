namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetGachaInfoScRsp
	{
		[ProtoMember(13)] public int Retcode;
		[ProtoMember(5)] public int GachaRandom;
		[ProtoMember(2)] public int Nmaojeiedak;
		[ProtoMember(10)] public List<GachaInfo> GachaInfoList;
		[ProtoMember(8)] public int Pgjdnmcpfie;
		[ProtoMember(1)] public int Ldhofgoikpi;
	}

}
