namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SceneEntityDieScNotify
	{
		[ProtoMember(9)] public List<int> EntityIdList;
	}

}
