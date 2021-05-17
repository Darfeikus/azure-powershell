// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Cmdlets
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.Extensions;

    /// <summary>
    /// Creates an input or replaces an already existing input under an existing streaming job.
    /// </summary>
    /// <remarks>
    /// [OpenAPI] CreateOrReplace=>PUT:"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/inputs/{inputName}"
    /// </remarks>
    [global::Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.InternalExport]
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsCommon.New, @"AzStreamAnalyticsInput_Create", SupportsShouldProcess = true)]
    [global::System.Management.Automation.OutputType(typeof(Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Models.Api20170401Preview.IInput))]
    [global::Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Description(@"Creates an input or replaces an already existing input under an existing streaming job.")]
    [global::Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Generated]
    public partial class NewAzStreamAnalyticsInput_Create : global::System.Management.Automation.PSCmdlet,
        Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.IEventListener
    {
        /// <summary>A unique id generatd for the this cmdlet when it is instantiated.</summary>
        private string __correlationId = System.Guid.NewGuid().ToString();

        /// <summary>A copy of the Invocation Info (necessary to allow asJob to clone this cmdlet)</summary>
        private global::System.Management.Automation.InvocationInfo __invocationInfo;

        /// <summary>A unique id generatd for the this cmdlet when ProcessRecord() is called.</summary>
        private string __processRecordId;

        /// <summary>
        /// The <see cref="global::System.Threading.CancellationTokenSource" /> for this operation.
        /// </summary>
        private global::System.Threading.CancellationTokenSource _cancellationTokenSource = new global::System.Threading.CancellationTokenSource();

        /// <summary>Wait for .NET debugger to attach</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Category(global::Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>The reference to the client API class.</summary>
        public Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.StreamAnalytics Client => Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Module.Instance.ClientAPI;

        /// <summary>
        /// The credentials, account, tenant, and subscription used for communication with Azure
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The credentials, account, tenant, and subscription used for communication with Azure.")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::System.Management.Automation.Alias("AzureRMContext", "AzureCredential")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Category(global::Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.ParameterCategory.Azure)]
        public global::System.Management.Automation.PSObject DefaultProfile { get; set; }

        /// <summary>SendAsync Pipeline Steps to be appended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Category(global::Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.SendAsyncStep[] HttpPipelineAppend { get; set; }

        /// <summary>SendAsync Pipeline Steps to be prepended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Category(global::Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.SendAsyncStep[] HttpPipelinePrepend { get; set; }

        /// <summary>Backing field for <see cref="IfMatch" /> property.</summary>
        private string _ifMatch;

        /// <summary>
        /// The ETag of the input. Omit this value to always overwrite the current input. Specify the last-seen ETag value to prevent
        /// accidentally overwriting concurrent changes.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The ETag of the input. Omit this value to always overwrite the current input. Specify the last-seen ETag value to prevent accidentally overwriting concurrent changes.")]
        [Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ETag of the input. Omit this value to always overwrite the current input. Specify the last-seen ETag value to prevent accidentally overwriting concurrent changes.",
        SerializedName = @"If-Match",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Category(global::Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.ParameterCategory.Header)]
        public string IfMatch { get => this._ifMatch; set => this._ifMatch = value; }

        /// <summary>Backing field for <see cref="IfNoneMatch" /> property.</summary>
        private string _ifNoneMatch;

        /// <summary>
        /// Set to '*' to allow a new input to be created, but to prevent updating an existing input. Other values will result in
        /// a 412 Pre-condition Failed response.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Set to '*' to allow a new input to be created, but to prevent updating an existing input. Other values will result in a 412 Pre-condition Failed response.")]
        [Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Set to '*' to allow a new input to be created, but to prevent updating an existing input. Other values will result in a 412 Pre-condition Failed response.",
        SerializedName = @"If-None-Match",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Category(global::Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.ParameterCategory.Header)]
        public string IfNoneMatch { get => this._ifNoneMatch; set => this._ifNoneMatch = value; }

        /// <summary>Backing field for <see cref="Input" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Models.Api20170401Preview.IInput _input;

        /// <summary>
        /// An input object, containing all information associated with the named input. All inputs are contained under a streaming
        /// job.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "An input object, containing all information associated with the named input. All inputs are contained under a streaming job.", ValueFromPipeline = true)]
        [Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"An input object, containing all information associated with the named input. All inputs are contained under a streaming job.",
        SerializedName = @"input",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Models.Api20170401Preview.IInput) })]
        public Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Models.Api20170401Preview.IInput Input { get => this._input; set => this._input = value; }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public global::System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>Backing field for <see cref="JobName" /> property.</summary>
        private string _jobName;

        /// <summary>The name of the streaming job.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The name of the streaming job.")]
        [Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the streaming job.",
        SerializedName = @"jobName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Category(global::Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.ParameterCategory.Path)]
        public string JobName { get => this._jobName; set => this._jobName = value; }

        /// <summary>
        /// <see cref="IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the input.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The name of the input.")]
        [Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the input.",
        SerializedName = @"inputName",
        PossibleTypes = new [] { typeof(string) })]
        [global::System.Management.Automation.Alias("InputName")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Category(global::Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.ParameterCategory.Path)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>
        /// The instance of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.HttpPipeline Pipeline { get; set; }

        /// <summary>The URI for the proxy server to use</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "The URI for the proxy server to use")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Category(global::Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.ParameterCategory.Runtime)]
        public global::System.Uri Proxy { get; set; }

        /// <summary>Credentials for a proxy server to use for the remote call</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Credentials for a proxy server to use for the remote call")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Category(global::Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.ParameterCategory.Runtime)]
        public global::System.Management.Automation.PSCredential ProxyCredential { get; set; }

        /// <summary>Use the default credentials for the proxy</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Use the default credentials for the proxy")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Category(global::Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter ProxyUseDefaultCredentials { get; set; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The name of the resource group. The name is case insensitive.")]
        [Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the resource group. The name is case insensitive.",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Category(global::Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.ParameterCategory.Path)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>The ID of the target subscription.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The ID of the target subscription.")]
        [Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The ID of the target subscription.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        [Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.DefaultInfo(
        Name = @"",
        Description =@"",
        Script = @"(Get-AzContext).Subscription.Id")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Category(global::Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.ParameterCategory.Path)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>
        /// <c>overrideOnCreated</c> will be called before the regular onCreated has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Models.Api20170401Preview.IInput"
        /// /> from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onCreated method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnCreated(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Models.Api20170401Preview.IInput> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Models.Api20170401Preview.IInput"
        /// /> from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Models.Api20170401Preview.IInput> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// (overrides the default BeginProcessing method in global::System.Management.Automation.PSCmdlet)
        /// </summary>
        protected override void BeginProcessing()
        {
            Module.Instance.SetProxyConfiguration(Proxy, ProxyCredential, ProxyUseDefaultCredentials);
            if (Break)
            {
                Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.AttachDebugger.Break();
            }
            ((Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.Events.CmdletBeginProcessing).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Performs clean-up after the command execution</summary>
        protected override void EndProcessing()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.Events.CmdletEndProcessing).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Handles/Dispatches events during the call to the REST service.</summary>
        /// <param name="id">The message id</param>
        /// <param name="token">The message cancellation token. When this call is cancelled, this should be <c>true</c></param>
        /// <param name="messageData">Detailed message data for the message event.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the message is completed.
        /// </returns>
         async global::System.Threading.Tasks.Task Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.IEventListener.Signal(string id, global::System.Threading.CancellationToken token, global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.EventData> messageData)
        {
            using( NoSynchronizationContext )
            {
                if (token.IsCancellationRequested)
                {
                    return ;
                }

                switch ( id )
                {
                    case Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.Events.Verbose:
                    {
                        WriteVerbose($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.Events.Warning:
                    {
                        WriteWarning($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.Events.Information:
                    {
                        var data = messageData();
                        WriteInformation(data, new[] { data.Message });
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.Events.Debug:
                    {
                        WriteDebug($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.Events.Error:
                    {
                        WriteError(new global::System.Management.Automation.ErrorRecord( new global::System.Exception(messageData().Message), string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null ) );
                        return ;
                    }
                }
                await Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Module.Instance.Signal(id, token, messageData, (i,t,m) => ((Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.IEventListener)this).Signal(i,t,()=> Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.EventDataConverter.ConvertFrom( m() ) as Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.EventData ), InvocationInformation, this.ParameterSetName, __correlationId, __processRecordId, null );
                if (token.IsCancellationRequested)
                {
                    return ;
                }
                WriteDebug($"{id}: {(messageData().Message ?? global::System.String.Empty)}");
            }
        }

        /// <summary>
        /// Intializes a new instance of the <see cref="NewAzStreamAnalyticsInput_Create" /> cmdlet class.
        /// </summary>
        public NewAzStreamAnalyticsInput_Create()
        {

        }

        /// <summary>Performs execution of the command.</summary>
        protected override void ProcessRecord()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            __processRecordId = System.Guid.NewGuid().ToString();
            try
            {
                // work
                if (ShouldProcess($"Call remote 'InputsCreateOrReplace' operation"))
                {
                    using( var asyncCommandRuntime = new Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.PowerShell.AsyncCommandRuntime(this, ((Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.IEventListener)this).Token) )
                    {
                        asyncCommandRuntime.Wait( ProcessRecordAsync(),((Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.IEventListener)this).Token);
                    }
                }
            }
            catch (global::System.AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach( var innerException in aggregateException.Flatten().InnerExceptions )
                {
                    ((Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.Events.CmdletException, $"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // Write exception out to error channel.
                    WriteError( new global::System.Management.Automation.ErrorRecord(innerException,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
                }
            }
            catch (global::System.Exception exception) when ((exception as System.Management.Automation.PipelineStoppedException)== null || (exception as System.Management.Automation.PipelineStoppedException).InnerException != null)
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                // Write exception out to error channel.
                WriteError( new global::System.Management.Automation.ErrorRecord(exception,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
            }
            finally
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.Events.CmdletProcessRecordEnd).Wait();
            }
        }

        /// <summary>Performs execution of the command, working asynchronously if required.</summary>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        protected async global::System.Threading.Tasks.Task ProcessRecordAsync()
        {
            using( NoSynchronizationContext )
            {
                await ((Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.Events.CmdletProcessRecordAsyncStart); if( ((Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                await ((Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.Events.CmdletGetPipeline); if( ((Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                Pipeline = Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Module.Instance.CreatePipeline(InvocationInformation, __correlationId, __processRecordId, this.ParameterSetName);
                if (null != HttpPipelinePrepend)
                {
                    Pipeline.Prepend((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelinePrepend) ?? HttpPipelinePrepend);
                }
                if (null != HttpPipelineAppend)
                {
                    Pipeline.Append((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelineAppend) ?? HttpPipelineAppend);
                }
                // get the client instance
                try
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.Events.CmdletBeforeAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    await this.Client.InputsCreateOrReplace(this.InvocationInformation.BoundParameters.ContainsKey("IfMatch") ? IfMatch : null, this.InvocationInformation.BoundParameters.ContainsKey("IfNoneMatch") ? IfNoneMatch : null, SubscriptionId, ResourceGroupName, JobName, Name, Input, onOk, onCreated, this, Pipeline);
                    await ((Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.Events.CmdletAfterAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new {  IfMatch=this.InvocationInformation.BoundParameters.ContainsKey("IfMatch") ? IfMatch : null,IfNoneMatch=this.InvocationInformation.BoundParameters.ContainsKey("IfNoneMatch") ? IfNoneMatch : null,SubscriptionId=SubscriptionId,ResourceGroupName=ResourceGroupName,JobName=JobName,Name=Name,body=Input})
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(urexception.Message) { RecommendedAction = urexception.Action }
                    });
                }
                finally
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }

        /// <summary>a delegate that is called when the remote service returns 201 (Created).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Models.Api20170401Preview.IInput"
        /// /> from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onCreated(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Models.Api20170401Preview.IInput> response)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnCreated(responseMessage, response, ref _returnNow);
                // if overrideOnCreated has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // onCreated - response for 201 / application/json
                // (await response) // should be Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Models.Api20170401Preview.IInput
                WriteObject((await response));
            }
        }

        /// <summary>a delegate that is called when the remote service returns 200 (OK).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Models.Api20170401Preview.IInput"
        /// /> from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Models.Api20170401Preview.IInput> response)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnOk(responseMessage, response, ref _returnNow);
                // if overrideOnOk has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // onOk - response for 200 / application/json
                // (await response) // should be Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Models.Api20170401Preview.IInput
                WriteObject((await response));
            }
        }
    }
}