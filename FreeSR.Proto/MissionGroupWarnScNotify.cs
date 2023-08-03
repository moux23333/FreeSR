namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class MissionGroupWarnScNotify
	{
		[ProtoMember(9)] public List<int> GroupIdList;
	}
	
}
