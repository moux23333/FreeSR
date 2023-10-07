namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SceneEntityDisappearScNotify
	{
		[ProtoMember(12)] public List<int> EntityIdList;
	}

}
