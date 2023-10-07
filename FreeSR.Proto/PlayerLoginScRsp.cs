namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class PlayerLoginScRsp
	{
		[ProtoMember(15)] public int Retcode;
		[ProtoMember(12)] public bool IsNewPlayer;
		[ProtoMember(8)] public string Fcajkkeinid;
		[ProtoMember(14)] public int CurTimezone;
		[ProtoMember(11)] public long ServerTimestampMs;
		[ProtoMember(2)] public PlayerBasicInfo BasicInfo;
		[ProtoMember(3)] public string Hnpfomcjijm;
		[ProtoMember(7)] public bool EPIIKAGFCNK;
		[ProtoMember(6)] public int Stamina;
		[ProtoMember(4)] public long LoginRandom;
	}

}
