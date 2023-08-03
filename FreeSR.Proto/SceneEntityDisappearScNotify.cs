namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SceneEntityDisappearScNotify
	{
		[ProtoMember(14)] public List<int> EntityIdList;
	}
	
}
