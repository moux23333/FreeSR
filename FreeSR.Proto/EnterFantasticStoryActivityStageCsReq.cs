namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class EnterFantasticStoryActivityStageCsReq
	{
		[ProtoMember(13)] public List<LJCKHIJJDAM> AvatarList;
		[ProtoMember(12)] public int BattleId;
		[ProtoMember(2)] public int KNBOIOPGGFN;
		[ProtoMember(5)] public List<int> BuffList;
	}
	
}
