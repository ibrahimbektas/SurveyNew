new Vue({
    el: '#deneme',
    data: {
        questions: [
            {
                id: 1,
                text: '',
                answerType: '',
                options: [],
            },
        ],
        
        
    },

    methods: {
        addQuestion() {
            this.questions.push({
                id: this.questions.length + 1,
                text: '',
                answerType,
                options: []
            });
        },
        removeQuestion(index) {
            this.questions.splice(index, 1);
        },
        addOption(question) { 
            question.options.push({
                id: question.options.length + 1,
                text: ''
            });
        },
        removeOption(question, index) {
            question.options.splice(index, 1);
        }
    },

    watch: {
        questions: {
            handler(questions) {
                questions.forEach((question) => {
                    if (question.answerType === 'Çoktan Seçmeli' && question.options.length === 0) {
                        this.addOption(question);
                    }
                });
            },
            deep: true
        }
    }

});

