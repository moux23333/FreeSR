namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class PlayerLoginScRsp
	{
		[ProtoMember(9)] public PlayerBasicInfo BasicInfo;
		[ProtoMember(6)] public bool IsNewPlayer;
		[ProtoMember(11)] public bool IsRelay;
		[ProtoMember(8)] public long LoginRandom;
		[ProtoMember(2)] public int Retcode;
		[ProtoMember(1)] public int CurServerTimezone;
		[ProtoMember(12)] public int Stamina;
		[ProtoMember(10)] public string HCCLEKMAHDO;
		[ProtoMember(15)] public string LHJECMFKAFD;
		[ProtoMember(5)] public long ServerTimestampMs;
	}
	
}
