namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SceneEntityTeleportCsReq
	{
		[ProtoMember(4)] public int EntryId;
		[ProtoMember(5)] public EntityMotion EntityMotion;
	}
	
}
