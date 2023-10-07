namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SceneEntityMoveScRsp
	{
		[ProtoMember(13)] public int Retcode;
		[ProtoMember(15)] public ClientDownloadData DownloadData;
		[ProtoMember(4)] public List<EntityMotion> EntityMotionList;
	}

}
