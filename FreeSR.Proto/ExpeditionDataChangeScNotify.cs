namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ExpeditionDataChangeScNotify
	{
		[ProtoMember(3)] public List<int> UnlockedExpeditionIdList;
		[ProtoMember(10)] public List<Expedition> ExpedtionList;
		[ProtoMember(13)] public int TeamCount;
	}
	
}
