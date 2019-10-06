import { Injectable } from '@angular/core';

declare var $: any;

@Injectable({
    providedIn: 'root'
})
export class SignalrService {
    private connection: any;
    private proxy: any;
    constructor() { }

    public initializeSignalRConnection(): void {
        let signalRServerEndPoint = 'http://localhost:53318/SignalR';
        this.connection = $.hubConnection(signalRServerEndPoint);
        this.proxy = this.connection.createHubProxy('SignalRHub')

        this.proxy.on('BroadcastCommonData', (serverMessage) => this.onMessageReceived(serverMessage));
        this.connection.start().done((data: any) => {
            console.log('Connected to Notification Hub');
            this.broadcastMessage();
        }).catch((error: any) => {
            console.log('Notification Hub error -> ' + error);
        });
    }
    private broadcastMessage(): void {
        this.proxy.invoke('BroadcastCommonData', { 'Timestamp': 'text message', 'From': 'text message', 'Message': 'text message' })
            .catch((error: any) => {
                console.log('broadcastMessage error -> ' + error);
            });
    }
    private onMessageReceived(serverMessage: string) {
        console.log('New message received from Server: ' + JSON.stringify(serverMessage));
    }
}