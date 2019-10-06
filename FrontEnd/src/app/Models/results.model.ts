export class Results {
    constructor(
        public round?: number,
        public playerWinner?: string,
        public player1Move?: string,
        public player2Move?: string,        
        public player1?: string,
        public player2?: string
    ) {}
}