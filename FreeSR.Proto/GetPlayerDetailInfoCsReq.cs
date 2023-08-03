namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetPlayerDetailInfoCsReq
	{
		[ProtoMember(6)] public int Uid;
	}
	
}
