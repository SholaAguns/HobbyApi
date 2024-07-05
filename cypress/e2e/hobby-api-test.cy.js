const apiUrl = `${Cypress.env("apiUrl")}`

function uuid() {
    return 'xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx'.replace(/[xy]/g, function(c) {
      var r = Math.random() * 16 | 0, v = c == 'x' ? r : (r & 0x3 | 0x8);
      return v.toString(16);
    });
  }

describe('Hobby API Cypress Test', () => {

    it('Healthcheck', () => {
        cy.request({
          failOnStatusCode: false,
          method: 'GET',
          url: `${apiUrl}/ping`,
        }).then((response) => {
          expect(response.status).to.eq(200)
        })
      })
      it('Successfully returns all hobbies in initial DB migration', () => {
        cy.request({
          failOnStatusCode: false,
          method: 'GET',
          url: `${apiUrl}`,
        }).then((response) => {
            assert.equal(response.status, 200, "200 status code shoule be returned")
            assert(response.body.result.length >= 10, "Hobbies missing")
        })
      })
      it('Get existing hobby', () => {
        const paintingID = "1ae7d626-8417-4f30-a890-143ef6f83206"
        cy.request({
          failOnStatusCode: false,
          method: 'GET',
          url: `${apiUrl}/${paintingID}`,
        }).then((response) => {
            assert.equal(response.status, 200, "200 status code shoule be returned")
            assert(response.body.length = 1, "Hobbies missing")
            expect(response.body).to.have.property('id', paintingID);
            expect(response.body).to.have.property('name', 'Painting');
            expect(response.body).to.have.property('category', 'Arts & Crafts');
            expect(response.body).to.have.property('description', 'The practice of applying paint, pigment, color, or other medium to a solid surface (such as canvas, paper, or wall) to create expressive or realistic works of art.');
            expect(response.body).to.have.property('rating', 6);
        })
      })
      it('Get non-existing hobby', () => {
        const newId = uuid()
        cy.request({
          failOnStatusCode: false,
          method: 'GET',
          url: `${apiUrl}/${newId}`,
        }).then((response) => {
            assert.equal(response.status, 404, "404 status code shoule be returned")
        })
      })
      it('Get existing hobbies by category', () => {
        const existingCategory = "Arts & Crafts"

        cy.request({
          failOnStatusCode: false,
          method: 'GET',
          url: `${apiUrl}`,
          qs: {
            category: existingCategory
          },
        }).then((response) => {
            assert.equal(response.status, 200, "200 status code shoule be returned")
            assert(response.body.result.length >= 3, "Hobbies missing")
        })
      })
      it('Get existing categories', () => {
        cy.request({
          failOnStatusCode: false,
          method: 'GET',
          url: `${apiUrl}/categories`,
        }).then((response) => {
            assert.equal(response.status, 200, "200 status code shoule be returned")
            assert(response.body.length >= 6, "Categories missing")
        })
      })
      it('Create new category', () => {
        cy.request({
          failOnStatusCode: false,
          method: 'POST',
          url: `${apiUrl}`,
          body: {
            "name": "Chess",
            "category": "Board games",
            "description": "A board game of strategic skill for two players, played on a chequered board",
            "rating": 6
          }
        }).then((response) => {
            assert.equal(response.status, 201, "201 status code shoule be returned")
            assert(response.body.length = 1, "Reponse body should have one hobby")
            expect(response.body).to.have.property('name', 'Chess');
            expect(response.body).to.have.property('category', 'Board games');
            expect(response.body).to.have.property('description', 'A board game of strategic skill for two players, played on a chequered board');
            expect(response.body).to.have.property('rating', 6);
        })
      })


})