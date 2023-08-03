namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SceneEntityMoveCsReq
	{
		[ProtoMember(14)] public int EntryId;
		[ProtoMember(4)] public long GOHDKCGEHGP;
		[ProtoMember(2)] public List<EntityMotion> EntityMotionList;
	}
	
}
