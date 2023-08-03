namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetExpeditionDataScRsp
	{
		[ProtoMember(9)] public List<Expedition> ExpedtionList;
		[ProtoMember(12)] public int TeamCount;
		[ProtoMember(13)] public int Retcode;
		[ProtoMember(1)] public List<int> UnlockedExpeditionIdList;
	}
	
}
