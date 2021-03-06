// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: video-catalog/video_catalog_service.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace KillrVideo.VideoCatalog {
  /// <summary>
  ///  Service responsible for tracking the catalog of available videos for playback
  /// </summary>
  public static class VideoCatalogService
  {
    static readonly string __ServiceName = "killrvideo.video_catalog.VideoCatalogService";

    static readonly Marshaller<global::KillrVideo.VideoCatalog.SubmitUploadedVideoRequest> __Marshaller_SubmitUploadedVideoRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::KillrVideo.VideoCatalog.SubmitUploadedVideoRequest.Parser.ParseFrom);
    static readonly Marshaller<global::KillrVideo.VideoCatalog.SubmitUploadedVideoResponse> __Marshaller_SubmitUploadedVideoResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::KillrVideo.VideoCatalog.SubmitUploadedVideoResponse.Parser.ParseFrom);
    static readonly Marshaller<global::KillrVideo.VideoCatalog.SubmitYouTubeVideoRequest> __Marshaller_SubmitYouTubeVideoRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::KillrVideo.VideoCatalog.SubmitYouTubeVideoRequest.Parser.ParseFrom);
    static readonly Marshaller<global::KillrVideo.VideoCatalog.SubmitYouTubeVideoResponse> __Marshaller_SubmitYouTubeVideoResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::KillrVideo.VideoCatalog.SubmitYouTubeVideoResponse.Parser.ParseFrom);
    static readonly Marshaller<global::KillrVideo.VideoCatalog.GetVideoRequest> __Marshaller_GetVideoRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::KillrVideo.VideoCatalog.GetVideoRequest.Parser.ParseFrom);
    static readonly Marshaller<global::KillrVideo.VideoCatalog.GetVideoResponse> __Marshaller_GetVideoResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::KillrVideo.VideoCatalog.GetVideoResponse.Parser.ParseFrom);
    static readonly Marshaller<global::KillrVideo.VideoCatalog.GetVideoPreviewsRequest> __Marshaller_GetVideoPreviewsRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::KillrVideo.VideoCatalog.GetVideoPreviewsRequest.Parser.ParseFrom);
    static readonly Marshaller<global::KillrVideo.VideoCatalog.GetVideoPreviewsResponse> __Marshaller_GetVideoPreviewsResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::KillrVideo.VideoCatalog.GetVideoPreviewsResponse.Parser.ParseFrom);
    static readonly Marshaller<global::KillrVideo.VideoCatalog.GetLatestVideoPreviewsRequest> __Marshaller_GetLatestVideoPreviewsRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::KillrVideo.VideoCatalog.GetLatestVideoPreviewsRequest.Parser.ParseFrom);
    static readonly Marshaller<global::KillrVideo.VideoCatalog.GetLatestVideoPreviewsResponse> __Marshaller_GetLatestVideoPreviewsResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::KillrVideo.VideoCatalog.GetLatestVideoPreviewsResponse.Parser.ParseFrom);
    static readonly Marshaller<global::KillrVideo.VideoCatalog.GetUserVideoPreviewsRequest> __Marshaller_GetUserVideoPreviewsRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::KillrVideo.VideoCatalog.GetUserVideoPreviewsRequest.Parser.ParseFrom);
    static readonly Marshaller<global::KillrVideo.VideoCatalog.GetUserVideoPreviewsResponse> __Marshaller_GetUserVideoPreviewsResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::KillrVideo.VideoCatalog.GetUserVideoPreviewsResponse.Parser.ParseFrom);

    static readonly Method<global::KillrVideo.VideoCatalog.SubmitUploadedVideoRequest, global::KillrVideo.VideoCatalog.SubmitUploadedVideoResponse> __Method_SubmitUploadedVideo = new Method<global::KillrVideo.VideoCatalog.SubmitUploadedVideoRequest, global::KillrVideo.VideoCatalog.SubmitUploadedVideoResponse>(
        MethodType.Unary,
        __ServiceName,
        "SubmitUploadedVideo",
        __Marshaller_SubmitUploadedVideoRequest,
        __Marshaller_SubmitUploadedVideoResponse);

    static readonly Method<global::KillrVideo.VideoCatalog.SubmitYouTubeVideoRequest, global::KillrVideo.VideoCatalog.SubmitYouTubeVideoResponse> __Method_SubmitYouTubeVideo = new Method<global::KillrVideo.VideoCatalog.SubmitYouTubeVideoRequest, global::KillrVideo.VideoCatalog.SubmitYouTubeVideoResponse>(
        MethodType.Unary,
        __ServiceName,
        "SubmitYouTubeVideo",
        __Marshaller_SubmitYouTubeVideoRequest,
        __Marshaller_SubmitYouTubeVideoResponse);

    static readonly Method<global::KillrVideo.VideoCatalog.GetVideoRequest, global::KillrVideo.VideoCatalog.GetVideoResponse> __Method_GetVideo = new Method<global::KillrVideo.VideoCatalog.GetVideoRequest, global::KillrVideo.VideoCatalog.GetVideoResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetVideo",
        __Marshaller_GetVideoRequest,
        __Marshaller_GetVideoResponse);

    static readonly Method<global::KillrVideo.VideoCatalog.GetVideoPreviewsRequest, global::KillrVideo.VideoCatalog.GetVideoPreviewsResponse> __Method_GetVideoPreviews = new Method<global::KillrVideo.VideoCatalog.GetVideoPreviewsRequest, global::KillrVideo.VideoCatalog.GetVideoPreviewsResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetVideoPreviews",
        __Marshaller_GetVideoPreviewsRequest,
        __Marshaller_GetVideoPreviewsResponse);

    static readonly Method<global::KillrVideo.VideoCatalog.GetLatestVideoPreviewsRequest, global::KillrVideo.VideoCatalog.GetLatestVideoPreviewsResponse> __Method_GetLatestVideoPreviews = new Method<global::KillrVideo.VideoCatalog.GetLatestVideoPreviewsRequest, global::KillrVideo.VideoCatalog.GetLatestVideoPreviewsResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetLatestVideoPreviews",
        __Marshaller_GetLatestVideoPreviewsRequest,
        __Marshaller_GetLatestVideoPreviewsResponse);

    static readonly Method<global::KillrVideo.VideoCatalog.GetUserVideoPreviewsRequest, global::KillrVideo.VideoCatalog.GetUserVideoPreviewsResponse> __Method_GetUserVideoPreviews = new Method<global::KillrVideo.VideoCatalog.GetUserVideoPreviewsRequest, global::KillrVideo.VideoCatalog.GetUserVideoPreviewsResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetUserVideoPreviews",
        __Marshaller_GetUserVideoPreviewsRequest,
        __Marshaller_GetUserVideoPreviewsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::KillrVideo.VideoCatalog.VideoCatalogServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of VideoCatalogService</summary>
    public abstract class VideoCatalogServiceBase
    {
      /// <summary>
      ///  Submit an uploaded video to the catalog
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::KillrVideo.VideoCatalog.SubmitUploadedVideoResponse> SubmitUploadedVideo(global::KillrVideo.VideoCatalog.SubmitUploadedVideoRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Submit a YouTube video to the catalog
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::KillrVideo.VideoCatalog.SubmitYouTubeVideoResponse> SubmitYouTubeVideo(global::KillrVideo.VideoCatalog.SubmitYouTubeVideoRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Gets a video from the catalog
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::KillrVideo.VideoCatalog.GetVideoResponse> GetVideo(global::KillrVideo.VideoCatalog.GetVideoRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Gets video previews for a limited number of videos from the catalog
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::KillrVideo.VideoCatalog.GetVideoPreviewsResponse> GetVideoPreviews(global::KillrVideo.VideoCatalog.GetVideoPreviewsRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Gets video previews for the latest (i.e. newest) videos from the catalog
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::KillrVideo.VideoCatalog.GetLatestVideoPreviewsResponse> GetLatestVideoPreviews(global::KillrVideo.VideoCatalog.GetLatestVideoPreviewsRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Gets video previews for videos added to the site by a particular user
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::KillrVideo.VideoCatalog.GetUserVideoPreviewsResponse> GetUserVideoPreviews(global::KillrVideo.VideoCatalog.GetUserVideoPreviewsRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for VideoCatalogService</summary>
    public class VideoCatalogServiceClient : ClientBase<VideoCatalogServiceClient>
    {
      /// <summary>Creates a new client for VideoCatalogService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public VideoCatalogServiceClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for VideoCatalogService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public VideoCatalogServiceClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected VideoCatalogServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected VideoCatalogServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      ///  Submit an uploaded video to the catalog
      /// </summary>
      public virtual global::KillrVideo.VideoCatalog.SubmitUploadedVideoResponse SubmitUploadedVideo(global::KillrVideo.VideoCatalog.SubmitUploadedVideoRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SubmitUploadedVideo(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Submit an uploaded video to the catalog
      /// </summary>
      public virtual global::KillrVideo.VideoCatalog.SubmitUploadedVideoResponse SubmitUploadedVideo(global::KillrVideo.VideoCatalog.SubmitUploadedVideoRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SubmitUploadedVideo, null, options, request);
      }
      /// <summary>
      ///  Submit an uploaded video to the catalog
      /// </summary>
      public virtual AsyncUnaryCall<global::KillrVideo.VideoCatalog.SubmitUploadedVideoResponse> SubmitUploadedVideoAsync(global::KillrVideo.VideoCatalog.SubmitUploadedVideoRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SubmitUploadedVideoAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Submit an uploaded video to the catalog
      /// </summary>
      public virtual AsyncUnaryCall<global::KillrVideo.VideoCatalog.SubmitUploadedVideoResponse> SubmitUploadedVideoAsync(global::KillrVideo.VideoCatalog.SubmitUploadedVideoRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SubmitUploadedVideo, null, options, request);
      }
      /// <summary>
      ///  Submit a YouTube video to the catalog
      /// </summary>
      public virtual global::KillrVideo.VideoCatalog.SubmitYouTubeVideoResponse SubmitYouTubeVideo(global::KillrVideo.VideoCatalog.SubmitYouTubeVideoRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SubmitYouTubeVideo(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Submit a YouTube video to the catalog
      /// </summary>
      public virtual global::KillrVideo.VideoCatalog.SubmitYouTubeVideoResponse SubmitYouTubeVideo(global::KillrVideo.VideoCatalog.SubmitYouTubeVideoRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SubmitYouTubeVideo, null, options, request);
      }
      /// <summary>
      ///  Submit a YouTube video to the catalog
      /// </summary>
      public virtual AsyncUnaryCall<global::KillrVideo.VideoCatalog.SubmitYouTubeVideoResponse> SubmitYouTubeVideoAsync(global::KillrVideo.VideoCatalog.SubmitYouTubeVideoRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SubmitYouTubeVideoAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Submit a YouTube video to the catalog
      /// </summary>
      public virtual AsyncUnaryCall<global::KillrVideo.VideoCatalog.SubmitYouTubeVideoResponse> SubmitYouTubeVideoAsync(global::KillrVideo.VideoCatalog.SubmitYouTubeVideoRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SubmitYouTubeVideo, null, options, request);
      }
      /// <summary>
      ///  Gets a video from the catalog
      /// </summary>
      public virtual global::KillrVideo.VideoCatalog.GetVideoResponse GetVideo(global::KillrVideo.VideoCatalog.GetVideoRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetVideo(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Gets a video from the catalog
      /// </summary>
      public virtual global::KillrVideo.VideoCatalog.GetVideoResponse GetVideo(global::KillrVideo.VideoCatalog.GetVideoRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetVideo, null, options, request);
      }
      /// <summary>
      ///  Gets a video from the catalog
      /// </summary>
      public virtual AsyncUnaryCall<global::KillrVideo.VideoCatalog.GetVideoResponse> GetVideoAsync(global::KillrVideo.VideoCatalog.GetVideoRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetVideoAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Gets a video from the catalog
      /// </summary>
      public virtual AsyncUnaryCall<global::KillrVideo.VideoCatalog.GetVideoResponse> GetVideoAsync(global::KillrVideo.VideoCatalog.GetVideoRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetVideo, null, options, request);
      }
      /// <summary>
      ///  Gets video previews for a limited number of videos from the catalog
      /// </summary>
      public virtual global::KillrVideo.VideoCatalog.GetVideoPreviewsResponse GetVideoPreviews(global::KillrVideo.VideoCatalog.GetVideoPreviewsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetVideoPreviews(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Gets video previews for a limited number of videos from the catalog
      /// </summary>
      public virtual global::KillrVideo.VideoCatalog.GetVideoPreviewsResponse GetVideoPreviews(global::KillrVideo.VideoCatalog.GetVideoPreviewsRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetVideoPreviews, null, options, request);
      }
      /// <summary>
      ///  Gets video previews for a limited number of videos from the catalog
      /// </summary>
      public virtual AsyncUnaryCall<global::KillrVideo.VideoCatalog.GetVideoPreviewsResponse> GetVideoPreviewsAsync(global::KillrVideo.VideoCatalog.GetVideoPreviewsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetVideoPreviewsAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Gets video previews for a limited number of videos from the catalog
      /// </summary>
      public virtual AsyncUnaryCall<global::KillrVideo.VideoCatalog.GetVideoPreviewsResponse> GetVideoPreviewsAsync(global::KillrVideo.VideoCatalog.GetVideoPreviewsRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetVideoPreviews, null, options, request);
      }
      /// <summary>
      ///  Gets video previews for the latest (i.e. newest) videos from the catalog
      /// </summary>
      public virtual global::KillrVideo.VideoCatalog.GetLatestVideoPreviewsResponse GetLatestVideoPreviews(global::KillrVideo.VideoCatalog.GetLatestVideoPreviewsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetLatestVideoPreviews(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Gets video previews for the latest (i.e. newest) videos from the catalog
      /// </summary>
      public virtual global::KillrVideo.VideoCatalog.GetLatestVideoPreviewsResponse GetLatestVideoPreviews(global::KillrVideo.VideoCatalog.GetLatestVideoPreviewsRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetLatestVideoPreviews, null, options, request);
      }
      /// <summary>
      ///  Gets video previews for the latest (i.e. newest) videos from the catalog
      /// </summary>
      public virtual AsyncUnaryCall<global::KillrVideo.VideoCatalog.GetLatestVideoPreviewsResponse> GetLatestVideoPreviewsAsync(global::KillrVideo.VideoCatalog.GetLatestVideoPreviewsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetLatestVideoPreviewsAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Gets video previews for the latest (i.e. newest) videos from the catalog
      /// </summary>
      public virtual AsyncUnaryCall<global::KillrVideo.VideoCatalog.GetLatestVideoPreviewsResponse> GetLatestVideoPreviewsAsync(global::KillrVideo.VideoCatalog.GetLatestVideoPreviewsRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetLatestVideoPreviews, null, options, request);
      }
      /// <summary>
      ///  Gets video previews for videos added to the site by a particular user
      /// </summary>
      public virtual global::KillrVideo.VideoCatalog.GetUserVideoPreviewsResponse GetUserVideoPreviews(global::KillrVideo.VideoCatalog.GetUserVideoPreviewsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetUserVideoPreviews(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Gets video previews for videos added to the site by a particular user
      /// </summary>
      public virtual global::KillrVideo.VideoCatalog.GetUserVideoPreviewsResponse GetUserVideoPreviews(global::KillrVideo.VideoCatalog.GetUserVideoPreviewsRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetUserVideoPreviews, null, options, request);
      }
      /// <summary>
      ///  Gets video previews for videos added to the site by a particular user
      /// </summary>
      public virtual AsyncUnaryCall<global::KillrVideo.VideoCatalog.GetUserVideoPreviewsResponse> GetUserVideoPreviewsAsync(global::KillrVideo.VideoCatalog.GetUserVideoPreviewsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetUserVideoPreviewsAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Gets video previews for videos added to the site by a particular user
      /// </summary>
      public virtual AsyncUnaryCall<global::KillrVideo.VideoCatalog.GetUserVideoPreviewsResponse> GetUserVideoPreviewsAsync(global::KillrVideo.VideoCatalog.GetUserVideoPreviewsRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetUserVideoPreviews, null, options, request);
      }
      protected override VideoCatalogServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new VideoCatalogServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(VideoCatalogServiceBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SubmitUploadedVideo, serviceImpl.SubmitUploadedVideo)
          .AddMethod(__Method_SubmitYouTubeVideo, serviceImpl.SubmitYouTubeVideo)
          .AddMethod(__Method_GetVideo, serviceImpl.GetVideo)
          .AddMethod(__Method_GetVideoPreviews, serviceImpl.GetVideoPreviews)
          .AddMethod(__Method_GetLatestVideoPreviews, serviceImpl.GetLatestVideoPreviews)
          .AddMethod(__Method_GetUserVideoPreviews, serviceImpl.GetUserVideoPreviews).Build();
    }

  }
}
#endregion
